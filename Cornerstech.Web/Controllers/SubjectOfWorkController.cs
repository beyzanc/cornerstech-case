using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.Web.Models.SubjectOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Cornerstech.Web.Controllers
{
    public class SubjectOfWorkController : Controller
    {

        private readonly ISubjectOfWorkService _subjectOfWokService;
        private readonly IAgreementService _agreementService;
        private readonly IAgreementSubjectService _agreementSubjectService;


        public SubjectOfWorkController(ISubjectOfWorkService subjectOfWorkService, IAgreementService agreementService, IAgreementSubjectService agreementSubjectService)
        {
            _subjectOfWokService = subjectOfWorkService;
            _agreementService = agreementService;
            _agreementSubjectService = agreementSubjectService;
        }

        public IActionResult Index(string term = "", string sortOrder = "Name", string sortDirection = "asc", string selectedCategory = "")
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();
            selectedCategory = string.IsNullOrEmpty(selectedCategory) || selectedCategory == "Tümü" ? "" : selectedCategory.ToLower();
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentSortDirection = sortDirection == "asc" ? "desc" : "asc"; 


            var categories = _subjectOfWokService.TGetList()
                    .Select(p => p.Category)
                    .Distinct()
                    .OrderBy(category => category)
                    .ToList();

            ViewBag.Categories = categories;

            var subjects = _subjectOfWokService.TGetList()
                .Include(a => a.AgreementSubjects)
                    .ThenInclude(ap => ap.Agreement)
                .Where(a =>
                    (string.IsNullOrEmpty(term) ||
                     a.Name.ToLower().Contains(term) ||
                     a.Description.ToLower().Contains(term) ||
                     a.Category.ToLower().Contains(term) ||
                    a.AgreementSubjects.Any(ap => ap.Agreement.Name.ToLower().Contains(term) &&
                    (string.IsNullOrEmpty(selectedCategory) || a.Category.ToLower() == selectedCategory))
)
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
            var selectedPartners = _agreementSubjectService.TGetList()
                                    .Where(ap => ap.AgreementId == id)
                                    .Select(ap => ap.SubjectId)
                                    .ToList();

            var viewModel = new SubjectOfWorkDetailsViewModel
            {
                Id = subject.Id,
                Name = subject.Name,
                Description = subject.Description,
                AgreementOptions = agreements.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name,
                    Selected = selectedPartners.Contains(p.Id)
                }).ToList()
            };

            ViewBag.Categories = _subjectOfWokService.TGetList()
                .Select(p => p.Category)
                .Distinct()
                .Select(i => new SelectListItem
                {
                    Value = i.ToString(),
                    Text = i.ToString()
                }).ToList();

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
                            _agreementSubjectService.TDelete(existingAgreement);
                        }
                    }
                }

                if (model.SelectedAgreements != null && model.SelectedAgreements.Any())
                {
                    foreach (var agreementId in model.SelectedAgreements)
                    {
                        if (!existingAgreements.Any(ep => ep.Id == agreementId))
                        {
                            _agreementSubjectService.TInsert(new AgreementSubject
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

            ViewData["SelectedAgreements"] = new List<SelectListItem>();

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

            return PartialView("Create", model);
        }
    }
}
