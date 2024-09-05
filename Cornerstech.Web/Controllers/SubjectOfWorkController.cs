using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.Web.Models.SubjectOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Cornerstech.Web.Controllers
{
    public class SubjectOfWorkController : Controller
    {

        private readonly ISubjectOfWorkService _subjectOfWokService;
        private readonly IAgreementService _agreementService;
        private readonly IPartnerService _partnerService;
        private readonly IAgreementSubjectService _agreementSubjectService;


        public SubjectOfWorkController(ISubjectOfWorkService subjectOfWorkService, IAgreementService agreementService, IAgreementSubjectService agreementSubjectService, IPartnerService partnerService)
        {
            _subjectOfWokService = subjectOfWorkService;
            _agreementService = agreementService;
            _agreementSubjectService = agreementSubjectService;
            _partnerService = partnerService;
        }

        // Filter and sort subjects based on the search term, selected categories, agreements, and date range
        public IActionResult Index(string term = "", string sortOrder = "Name", string sortDirection = "asc",
                                    string[] selectedCategories = null, string[] selectedAgreements = null, DateTime? minDate = null, DateTime? maxDate = null)
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentSortDirection = sortDirection == "asc" ? "desc" : "asc";

            int? partnerId = null;
            if (!User.IsInRole("Admin"))
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (int.TryParse(userId, out int parsedUserId))
                {
                    partnerId = _partnerService.GetPartnerIdByUserId(parsedUserId);
                }
            }

            var categories = _subjectOfWokService.TGetList()
                .Where(p => !string.IsNullOrEmpty(p.Category))
                .Select(p => new SelectListItem
                {
                    Value = p.Category,
                    Text = p.Category
                })
                .Distinct()
                .OrderBy(item => item.Text)
                .ToList();

            var agreements = _agreementService.TGetList()
                .Where(p => !string.IsNullOrEmpty(p.Name))
                .Select(p => new SelectListItem
                {
                    Value = p.Name,
                    Text = p.Name
                })
                .Distinct()
                .OrderBy(item => item.Text)
                .ToList();

            ViewBag.SelectedAgreements = agreements;
            ViewBag.SelectedCategories = categories;

            var subjects = _subjectOfWokService.TGetList()
                .Include(a => a.AgreementSubjects)
                    .ThenInclude(ap => ap.Agreement)
                    .ThenInclude(ag => ag.AgreementPartners)
                    .ThenInclude(ap => ap.Partner)
                .Where(a =>
                    (string.IsNullOrEmpty(term) ||
                     a.Name.ToLower().Contains(term) ||
                     a.Description.ToLower().Contains(term) ||
                     a.Category.ToLower().Contains(term) ||
                     a.AgreementSubjects.Any(ap => ap.Agreement.Name.ToLower().Contains(term))) &&
                    (selectedCategories == null || selectedCategories.Length == 0 || selectedCategories.Contains(a.Category)) &&
                    (selectedAgreements == null || selectedAgreements.Length == 0 || a.AgreementSubjects.Any(ap => selectedAgreements.Contains(ap.Agreement.Name))) &&
                    (!minDate.HasValue || a.CreatedDate >= minDate.Value) && (!maxDate.HasValue || a.CreatedDate <= maxDate.Value) &&
                    (partnerId == null || a.AgreementSubjects.Any(asub => asub.Agreement.AgreementPartners.Any(ap => ap.PartnerId == partnerId)))
                ).ToList();

            subjects = sortOrder switch
            {
                "Name" => (sortDirection == "asc" ? subjects.OrderBy(a => a.Name) : subjects.OrderByDescending(a => a.Name)).ToList(),
                "Description" => (sortDirection == "asc" ? subjects.OrderBy(a => a.Description) : subjects.OrderByDescending(a => a.Description)).ToList(),
                "Category" => (sortDirection == "asc" ? subjects.OrderBy(a => a.Category) : subjects.OrderByDescending(a => a.Category)).ToList(),
                "Agreement" => (sortDirection == "asc"
                    ? subjects.OrderBy(a => string.Join(", ", a.AgreementSubjects.Select(ap => ap.Agreement.Name).OrderBy(name => name)))
                    : subjects.OrderByDescending(a => string.Join(", ", a.AgreementSubjects.Select(ap => ap.Agreement.Name).OrderBy(name => name))))
                    .ToList(),
                _ => subjects.ToList()
            };

            return View(subjects);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var subject = _subjectOfWokService.TGetByID(id);
            if (subject == null)
            {
                return NotFound("Konu bulunamadı.");
            }

            _subjectOfWokService.TDelete(subject);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var subject = _subjectOfWokService.TGetByID(id);
            if (subject == null)
            {
                return NotFound("Anlaşma bulunamadı.");
            }

            var agreements = _agreementService.TGetList();

            var selectedAgreements = _agreementSubjectService.TGetList()
                                              .Where(ap => ap.SubjectId == id)
                                              .Select(ap => ap.AgreementId)
                                              .ToList();

            var viewModel = new SubjectOfWorkDetailsViewModel
            {
                Id = subject.Id,
                Name = subject.Name,
                Description = subject.Description,
                Category = subject.Category,
                AgreementOptions = agreements
                    .Select(p => new SelectListItem
                    {
                        Value = p.Id.ToString(),
                        Text = p.Name,
                        Selected = selectedAgreements.Contains(p.Id)
                    })
                    .ToList()
            };

            ViewBag.Categories = _subjectOfWokService.TGetList()
                .Select(p => new SelectListItem
                {
                    Value = p.Category,
                    Text = p.Category
                }).Distinct().ToList();

            return PartialView("Edit", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SubjectOfWorkDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subject = _subjectOfWokService.TGetByID(model.Id);
                if (subject == null)
                {
                    return NotFound("Anlaşma bulunamadı.");
                }

                subject.Name = model.Name;
                subject.Description = model.Description;
                subject.Category = model.Category;


                _subjectOfWokService.TUpdate(subject);

                var existingAgreements = _agreementSubjectService.TGetList()
                                            .Where(ap => ap.AgreementId == model.Id)
                                            .ToList();

                if (existingAgreements != null && existingAgreements.Any())
                {
                    foreach (var existingAgreement in existingAgreements)
                    {
                        if (!model.SelectedAgreements.Contains(existingAgreement.AgreementId))
                        {
                            _agreementSubjectService.TDelete(existingAgreement); // Remove unselected agreements
                        }
                    }
                }

                if (model.SelectedAgreements != null && model.SelectedAgreements.Any())
                {
                    foreach (var agreementId in model.SelectedAgreements)
                    {
                        if (!existingAgreements.Any(ep => ep.Id == agreementId))
                        {
                            _agreementSubjectService.TInsert(new AgreementSubject // Add new agreements
                            {
                                SubjectId = model.Id,
                                AgreementId = agreementId
                            });
                        }
                    }
                }         

                return RedirectToAction("Index");
            }

            return PartialView("Edit", model);
        }

        public IActionResult Create()
        {
            ViewData["Agreements"] = _agreementService.TGetList()
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                }).ToList();

            ViewData["Categories"] = _subjectOfWokService.TGetList()
                .Where(p => !string.IsNullOrEmpty(p.Category))
                .Select(p => new SelectListItem
                {
                    Value = p.Category,
                    Text = p.Category
                })
                .Distinct()
                .OrderBy(item => item.Text)
                .ToList();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SubjectOfWorkCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var subject = new SubjectOfWork
                {
                    Name = model.Name,
                    Description = model.Description,
                    Category = model.Category,
                    CreatedDate = DateTime.Now,
                };

                _subjectOfWokService.TInsert(subject);

                // Add selected agreements
                if (model.SelectedAgreements != null && model.SelectedAgreements.Any())
                {
                    foreach (var agreementId in model.SelectedAgreements)
                    {
                        var agreementSubject = new AgreementSubject
                        {
                            SubjectId = subject.Id,
                            AgreementId = agreementId
                        };
                        _agreementSubjectService.TInsert(agreementSubject);
                    }
                }

                return RedirectToAction("Index");
            }

            ViewData["Agreements"] = _agreementService.TGetList()
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                }).ToList();

            ViewData["Categories"] = _subjectOfWokService.TGetList()
                .Where(p => !string.IsNullOrEmpty(p.Category))
                .Select(p => new SelectListItem
                {
                    Value = p.Category,
                    Text = p.Category
                })
                .Distinct()
                .OrderBy(item => item.Text)
                .ToList();

            return PartialView("Create", model);
        }
    }
}
