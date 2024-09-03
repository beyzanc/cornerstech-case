using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.Web.Models.Partner;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cornerstech.Web.Controllers
{
    public class PartnerController : Controller
    {
        private readonly IPartnerService _partnerService;
        private readonly IAgreementPartnerService _agreementPartnerService;
        private readonly IAgreementService _agreementService;


        public PartnerController(IPartnerService partnerService, IAgreementPartnerService agreementPartnerService, IAgreementService agreementService)
        {
            _partnerService = partnerService;
            _agreementPartnerService = agreementPartnerService;
            _agreementService = agreementService;
        }

        public IActionResult Index(string term = "", string selectedIndustry = "", string sortOrder = "Name", string sortDirection = "asc")
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();
            selectedIndustry = string.IsNullOrEmpty(selectedIndustry) || selectedIndustry == "Tümü" ? "" : selectedIndustry.ToLower();

            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentSortDirection = sortDirection == "asc" ? "desc" : "asc";

            var industries = _partnerService.TGetList()
                                .Select(p => p.Industry)
                                .Distinct()
                                .OrderBy(industry => industry)
                                .ToList();
            ViewBag.Industries = industries;

            var partners = _partnerService.TGetList()
                               .Where(p => (string.IsNullOrEmpty(term) ||
                                            p.Name.ToLower().Contains(term) ||
                                            p.ContactEmail.ToLower().Contains(term) ||
                                            p.Industry.ToLower().Contains(term)) &&
                                           (string.IsNullOrEmpty(selectedIndustry) || p.Industry.ToLower() == selectedIndustry))
                               .ToList();

            partners = sortOrder switch
            {
                "Name" => (sortDirection == "asc" ? partners.OrderBy(p => p.Name) : partners.OrderByDescending(p => p.Name)).ToList(),
                "City" => (sortDirection == "asc" ? partners.OrderBy(p => p.City) : partners.OrderByDescending(p => p.City)).ToList(),
                "Industry" => (sortDirection == "asc" ? partners.OrderBy(p => p.Industry) : partners.OrderByDescending(p => p.Industry)).ToList(),
                "Email" => (sortDirection == "asc" ? partners.OrderBy(p => p.ContactEmail) : partners.OrderByDescending(p => p.ContactEmail)).ToList(),
                "Phone" => (sortDirection == "asc" ? partners.OrderBy(p => p.PhoneNumber) : partners.OrderByDescending(p => p.PhoneNumber)).ToList(),
                "CreatedDate" => (sortDirection == "asc" ? partners.OrderBy(p => p.CreatedDate) : partners.OrderByDescending(p => p.CreatedDate)).ToList(),
                _ => partners.OrderByDescending(p => p.Name).ToList()
            };

            return View(partners);
        }

        // GET
        public IActionResult GetAgreementsByPartner(int partnerId, string term = "", string sortOrder = "Name", string sortDirection = "asc", string selectedStatus = "")
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentSortDirection = sortDirection == "asc" ? "desc" : "asc";

            var partner = _partnerService.TGetByID(partnerId); 
            ViewBag.PartnerName = partner?.Name ?? "Bilinmeyen Partner";
            ViewBag.PartnerId = partner?.Id ?? 0;

            var agreements = _agreementService.TGetList()
                                    .Include(a => a.AgreementPartners)
                                    .ThenInclude(ap => ap.Partner)
                                    .Where(a => a.AgreementPartners.Any(ap => ap.PartnerId == partnerId))
                                    .Include(a => a.AgreementRisks)
                                    .ThenInclude(ar => ar.Risk)
                                    .Include(a => a.AgreementSubjects)
                                    .ThenInclude(asub => asub.Subject)
                                    .Select(a => new
                                    {
                                        Agreement = a,
                                        Partners = a.AgreementPartners.Select(ap => ap.Partner.Name).ToList(),
                                        Risks = a.AgreementRisks.Select(r => r.Risk.Name).ToList(),
                                        Subjects = a.AgreementSubjects.Select(s => s.Subject.Name).ToList()
                                    }).ToList();

            agreements = sortOrder switch
            {
                "No" => (sortDirection == "asc" ? agreements.OrderBy(a => a.Agreement.Id) : agreements.OrderByDescending(a => a.Agreement.Id)).ToList(),
                "Name" => (sortDirection == "asc" ? agreements.OrderBy(a => a.Agreement.Name) : agreements.OrderByDescending(a => a.Agreement.Name)).ToList(),
                "Partner" => (sortDirection == "asc" ? agreements.OrderBy(a => string.Join(", ", a.Partners)) : agreements.OrderByDescending(a => string.Join(", ", a.Partners))).ToList(),
                "StartDate" => (sortDirection == "asc" ? agreements.OrderBy(a => a.Agreement.StartDate) : agreements.OrderByDescending(a => a.Agreement.StartDate)).ToList(),
                "EndDate" => (sortDirection == "asc" ? agreements.OrderBy(a => a.Agreement.EndDate) : agreements.OrderByDescending(a => a.Agreement.EndDate)).ToList(),
                "Status" => (sortDirection == "asc" ? agreements.OrderBy(a => a.Agreement.Status) : agreements.OrderByDescending(a => a.Agreement.Status)).ToList(),
                "CreatedDate" => (sortDirection == "asc" ? agreements.OrderBy(a => a.Agreement.CreatedDate) : agreements.OrderByDescending(a => a.Agreement.CreatedDate)).ToList(),
                _ => agreements.OrderByDescending(a => a.Agreement.CreatedDate).ToList()
            };

            return View(agreements);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var partner = _partnerService.TGetByID(id);
            if (partner == null)
            {
                return NotFound("Ortak bulunamadı.");
            }


            _partnerService.TDelete(partner);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var partner = _partnerService.TGetByID(id);
            if (partner == null)
            {
                return NotFound("Partner bulunamadı.");
            }

            ViewBag.Industries = _partnerService.TGetList()
                .Select(p => p.Industry)
                .Distinct()
                .Select(i => new SelectListItem
                {
                    Value = i.ToString(),
                    Text = i.ToString()
                }).ToList();

            var viewModel = new PartnerDetailsViewModel
            {
                Id = partner.Id,
                Name = partner.Name,
                ContactEmail = partner.ContactEmail,
                PhoneNumber = partner.PhoneNumber,
                City = partner.City ?? "",
                Industry = partner.Industry ?? "",
                CreatedDate = partner.CreatedDate
            };

            return PartialView("Edit", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PartnerDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var partner = _partnerService.TGetByID(model.Id);
                if (partner == null)
                {
                    return NotFound("Partner bulunamadı.");
                }


                partner.Name = model.Name;
                partner.ContactEmail = model.ContactEmail;
                partner.PhoneNumber = model.PhoneNumber;
                partner.City = model.City ?? "";
                partner.Industry = model.Industry ?? "";

                _partnerService.TUpdate(partner);


                return RedirectToAction("Index");
            }

            return PartialView("Edit", model);
        }

        public IActionResult Create()
        {

            ViewBag.Industries = _partnerService.TGetList()
                .Select(p => new SelectListItem
                {
                    Value = p.Industry,
                    Text = p.Industry
                }).Distinct().ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PartnerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var selectedIndustry = _partnerService.TGetList()
                            .FirstOrDefault(p => p.Id.ToString() == model.Industry);

                var partner = new Partner()
                {
                    Name = model.Name,
                    ContactEmail = model.ContactEmail,
                    PhoneNumber = model.PhoneNumber,
                    CreatedDate = DateTime.Now,
                    City = model.City ?? "",
                    Industry = selectedIndustry?.Name ?? ""
                };

                _partnerService.TInsert(partner);

                return RedirectToAction("Index");
            }

            ViewBag.Industries = _partnerService.TGetList()
                                        .Select(p => new SelectListItem
                                        {
                                            Value = p.Id.ToString(),
                                            Text = p.Name
                                        }).ToList();

            return PartialView("Create", model);
        }

        [HttpPost]
        public IActionResult RemovePartnerFromAgreement(int agreementId, int partnerId)
        {
            var agreementPartners = _agreementPartnerService.TGetList()
                                        .Where(ap => ap.AgreementId == agreementId && ap.PartnerId == partnerId).ToList();

            if (agreementPartners == null || !agreementPartners.Any())
            {
                return NotFound("Partner anlaşması bulunamadı.");
            }

            foreach (var agreementPartner in agreementPartners)
            {
                _agreementPartnerService.TDelete(agreementPartner);
            }

            return RedirectToAction("GetAgreementsByPartner", new { partnerId = partnerId });
        }

    }
}