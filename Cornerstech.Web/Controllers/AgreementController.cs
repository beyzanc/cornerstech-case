using Microsoft.AspNetCore.Mvc;
using Cornerstech.BusinessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using Cornerstech.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cornerstech.Web.Models.Agreement;

namespace Cornerstech.Web.Controllers
{
    public class AgreementController : Controller
    {
        private readonly IAgreementService _agreementService;
        private readonly IPartnerService _partnerService;
        private readonly IAgreementPartnerService _agreementPartnerService;
        private readonly IAgreementRiskService _agreementRiskService;
        private readonly IAgreementSubjectService _agreementSubjectService;
        private readonly IRiskService _riskService;
        private readonly ISubjectOfWorkService _subjectService;
        private readonly INotificationService _notificationService;
        private readonly INotificationApplicationUserService _notificationApplicationUserService;
        private readonly IUserService _userService;


        public AgreementController(IAgreementService agreementService, IPartnerService partnerService,
                                    IAgreementPartnerService agreementPartnerService, IRiskService riskService, 
                                        IAgreementRiskService agreementRiskService, IAgreementSubjectService agreementSubjectService, 
                                            ISubjectOfWorkService subjectService, INotificationService notificationService, 
                                                INotificationApplicationUserService notificationApplicationUserService, IUserService userService)
        {
            _agreementService = agreementService;
            _partnerService = partnerService;
            _agreementPartnerService = agreementPartnerService;
            _riskService = riskService;
            _agreementRiskService = agreementRiskService;
            _agreementSubjectService = agreementSubjectService;
            _subjectService = subjectService;
            _notificationService = notificationService;
            _notificationApplicationUserService = notificationApplicationUserService;
            _userService = userService;
        }

        // GET: AllAgreements
        public IActionResult Index(string term = "", string sortOrder = "Name", string sortDirection = "asc", string selectedStatus = "")
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();
            selectedStatus = string.IsNullOrEmpty(selectedStatus) || selectedStatus == "Tümü" ? "" : selectedStatus.ToLower();
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentSortDirection = sortDirection == "asc" ? "desc" : "asc";

            var agreementPartners = _agreementService.TGetList()
                .Include(a => a.AgreementPartners)
                .ThenInclude(ap => ap.Partner)
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
                })
                .Where(a => (string.IsNullOrEmpty(term) ||
                             a.Partners.Any(p => p.ToLower().Contains(term)) ||
                             a.Agreement.Name.ToLower().Contains(term) ||
                             a.Risks.Any(r => r.ToLower().Contains(term)) ||
                             a.Subjects.Any(s => s.ToLower().Contains(term))) &&
                            (string.IsNullOrEmpty(selectedStatus) || a.Agreement.Status.ToLower() == selectedStatus))
                .ToList();

            agreementPartners = sortOrder switch
            {
                "No" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.Id) : agreementPartners.OrderByDescending(a => a.Agreement.Id)).ToList(),
                "Name" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.Name) : agreementPartners.OrderByDescending(a => a.Agreement.Name)).ToList(),
                "Description" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.Description) : agreementPartners.OrderByDescending(a => a.Agreement.Description)).ToList(),
                "Partner" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => string.Join(", ", a.Partners)) : agreementPartners.OrderByDescending(a => string.Join(", ", a.Partners))).ToList(),
                "StartDate" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.StartDate) : agreementPartners.OrderByDescending(a => a.Agreement.StartDate)).ToList(),
                "EndDate" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.EndDate) : agreementPartners.OrderByDescending(a => a.Agreement.EndDate)).ToList(),
                "Status" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.Status) : agreementPartners.OrderByDescending(a => a.Agreement.Status)).ToList(),
                "Risk" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => string.Join(", ", a.Risks)) : agreementPartners.OrderByDescending(a => string.Join(", ", a.Risks))).ToList(),
                "Subject" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => string.Join(", ", a.Subjects)) : agreementPartners.OrderByDescending(a => string.Join(", ", a.Subjects))).ToList(),
                "CreatedDate" => (sortDirection == "asc" ? agreementPartners.OrderBy(a => a.Agreement.CreatedDate) : agreementPartners.OrderByDescending(a => a.Agreement.CreatedDate)).ToList(),
                _ => agreementPartners.OrderByDescending(a => a.Agreement.CreatedDate).ToList()
            };

            return View(agreementPartners);
        }
                        
        public IActionResult Create()
        {
            ViewData["Partners"] = _partnerService.TGetList()
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                }).ToList();

            ViewData["Risks"] = _riskService.TGetList()
                .Select(r => new SelectListItem
                {
                    Value = r.Id.ToString(),
                    Text = r.Name
                }).ToList();

            ViewData["Subjects"] = _subjectService.TGetList()
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AgreementCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var agreement = new Agreement
                {
                    Name = model.Name,
                    Description = model.Description,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    CreatedDate = DateTime.Now,
                    Status = model.Status
                };

                _agreementService.TInsert(agreement);

                if (model.SelectedPartners != null && model.SelectedPartners.Any())
                {
                    foreach (var partnerId in model.SelectedPartners)
                    {
                        var agreementPartner = new AgreementPartner
                        {
                            AgreementId = agreement.Id,
                            PartnerId = partnerId
                        };
                        _agreementPartnerService.TInsert(agreementPartner);

                        var notification = new Notification
                        {
                            Text = "Yeni bir anlaşma oluşturuldu: " + agreement.Name
                        };

                        _notificationService.TInsert(notification);
                        var notificationId = notification.Id;

                        var notificationUser = new NotificationApplicationUser
                        {
                            ApplicationUserId = _userService.GetUserIdByPartnerId(partnerId) ?? 0,
                            NotificationId = notificationId
                        };

                        _notificationApplicationUserService.TInsert(notificationUser);
                    }
                }

                if (model.SelectedRisks != null && model.SelectedRisks.Any())
                {
                    foreach (var riskId in model.SelectedRisks)
                    {
                        var agreementRisk = new AgreementRisk
                        {
                            AgreementId = agreement.Id,
                            RiskId = riskId
                        };
                        _agreementRiskService.TInsert(agreementRisk);

                        var risk = _riskService.TGetByID(riskId);
                    }
                }

                if (model.SelectedSubjects != null && model.SelectedSubjects.Any())
                {
                    foreach (var subjectId in model.SelectedSubjects)
                    {
                        var agreementSubject = new AgreementSubject
                        {
                            AgreementId = agreement.Id,
                            SubjectId = subjectId
                        };
                        _agreementSubjectService.TInsert(agreementSubject);
                    }
                }

                if (model.SelectedRisks != null && model.SelectedRisks.Any() && model.SelectedPartners != null && model.SelectedPartners.Any())
                {
                    foreach (var riskId in model.SelectedRisks)
                    {
                        foreach (var partner in model.SelectedPartners)
                        {
                            var risk = _riskService.TGetByID(riskId);

                            if (risk != null)
                            {
                                double riskValue = _riskService.GetRiskValueByRiskName(risk.Name);

                                var notification = new Notification
                                {
                                    Text = agreement.Name + " anlaşması için risk skoru " + riskValue.ToString() + " olarak hesaplanmıştır. (" + risk.Name + ")"
                                };

                                _notificationService.TInsert(notification);
                                var notificationId = notification.Id;

                                var notificationUser = new NotificationApplicationUser
                                {
                                    ApplicationUserId = _userService.GetUserIdByPartnerId(partner) ?? 0,
                                    NotificationId = notificationId
                                };

                                _notificationApplicationUserService.TInsert(notificationUser);
                            }
                        }
                    }

                }
                return RedirectToAction("Index");

            }

            ViewData["Partners"] = _partnerService.TGetList()
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name
                }).ToList();

            ViewData["Risks"] = _riskService.TGetList()
                .Select(r => new SelectListItem
                {
                    Value = r.Id.ToString(),
                    Text = r.Name
                }).ToList();

            ViewData["Subjects"] = _subjectService.TGetList()
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name
                }).ToList();

            return PartialView("Create", model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var agreement = _agreementService.TGetByID(id);
            if (agreement == null)
            {
                return NotFound("Anlaşma bulunamadı.");
            }

            var agreementPartners = _agreementPartnerService.TGetList().Where(ap => ap.AgreementId == id).ToList();
            foreach (var agreementPartner in agreementPartners)
            {
                _agreementPartnerService.TDelete(agreementPartner);
            }

            _agreementService.TDelete(agreement);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var agreement = _agreementService.TGetByID(id);
            if (agreement == null)
            {
                return NotFound("Anlaşma bulunamadı.");
            }

            var partners = _partnerService.TGetList();
            var selectedPartners = _agreementPartnerService.TGetList()
                                    .Where(ap => ap.AgreementId == id)
                                    .Select(ap => ap.PartnerId)
                                    .ToList();

            var risks = _riskService.TGetList();
            var selectedRisks = _agreementRiskService.TGetList()
                                    .Where(ap => ap.AgreementId == id)
                                    .Select(ap => ap.RiskId)
                                    .ToList();

            var subjects = _subjectService.TGetList();
            var selectedSubjects = _agreementSubjectService.TGetList()
                                    .Where(ap => ap.AgreementId == id)
                                    .Select(ap => ap.SubjectId)
                                    .ToList();

            var viewModel = new AgreementDetailsViewModel
            {
                Id = agreement.Id,
                Name = agreement.Name,
                Description= agreement.Description,
                StartDate = agreement.StartDate ?? DateTime.MinValue,
                EndDate = agreement.EndDate ?? DateTime.MinValue,
                Status = agreement.Status ?? "",
                CreatedDate = agreement.CreatedDate,
                SelectedPartners = selectedPartners,
                PartnerOptions = partners.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name,
                    Selected = selectedPartners.Contains(p.Id)
                }).ToList(),
                SubjectOptions = subjects.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name,
                    Selected = selectedSubjects.Contains(p.Id)
                }).ToList(),
                RiskOptions = risks.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.Name,
                    Selected = selectedRisks.Contains(p.Id)
                }).ToList(),
            };

            ViewBag.StatusOptions = new List<SelectListItem>
                                                            {
                                                                new SelectListItem { Text = "Tamamlandı", Value = "Tamamlandı" },
                                                                new SelectListItem { Text = "Görüşülüyor", Value = "Görüşülüyor" },
                                                                new SelectListItem { Text = "İmzalandı", Value = "İmzalandı" },
                                                                new SelectListItem { Text = "İptal Edildi", Value = "İptal Edildi" },
                                                                new SelectListItem { Text = "Beklemede", Value = "Beklemede" }
                                                            };

            return PartialView("Edit", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AgreementDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var agreement = _agreementService.TGetByID(model.Id);
                if (agreement == null)
                {
                    return NotFound("Anlaşma bulunamadı.");
                }

                agreement.Name = model.Name;
                agreement.Description = model.Description;
                agreement.StartDate = model.StartDate ?? agreement.StartDate;
                agreement.EndDate = model.EndDate ?? agreement.EndDate;
                agreement.Status = model.Status ?? "";

                _agreementService.TUpdate(agreement);

                var existingPartners = _agreementPartnerService.TGetList()
                                            .Where(ap => ap.AgreementId == model.Id)
                                            .ToList();

                var existingRisks = _agreementRiskService.TGetList()
                        .Where(ar => ar.AgreementId == model.Id)
                        .ToList();

                var existingSubjects = _agreementSubjectService.TGetList()
                           .Where(asub => asub.AgreementId == model.Id)
                           .ToList();


                if (existingPartners != null && existingPartners.Any())
                {
                    foreach (var existingPartner in existingPartners)
                    {
                        if (!model.SelectedPartners.Contains(existingPartner.PartnerId))
                        {
                            _agreementPartnerService.TDelete(existingPartner);
                        }
                    }
                }

                if (model.SelectedPartners != null && model.SelectedPartners.Any())
                {
                    foreach (var partnerId in model.SelectedPartners)
                    {
                        if (!existingPartners.Any(ep => ep.PartnerId == partnerId))
                        {
                            _agreementPartnerService.TInsert(new AgreementPartner
                            {
                                AgreementId = model.Id,
                                PartnerId = partnerId
                            });
                        }
                    }
                }

                if (existingRisks != null && existingRisks.Any())
                {
                    foreach (var existingRisk in existingRisks)
                    {
                        if (!model.SelectedRisks.Contains(existingRisk.RiskId))
                        {
                            _agreementRiskService.TDelete(existingRisk);
                        }
                    }
                }

                if (model.SelectedRisks != null && model.SelectedRisks.Any())
                {
                    foreach (var riskId in model.SelectedRisks)
                    {
                        if (!existingRisks.Any(er => er.RiskId == riskId))
                        {
                            _agreementRiskService.TInsert(new AgreementRisk
                            {
                                AgreementId = model.Id,
                                RiskId = riskId
                            });
                        }
                    }
                }

                if (existingSubjects != null && existingSubjects.Any())
                {
                    foreach (var existingSubject in existingSubjects)
                    {
                        if (!model.SelectedSubjects.Contains(existingSubject.SubjectId))
                        {
                            _agreementSubjectService.TDelete(existingSubject);
                        }
                    }
                }

                if (model.SelectedSubjects != null && model.SelectedSubjects.Any())
                {
                    foreach (var subjectId in model.SelectedSubjects)
                    {
                        if (!existingSubjects.Any(es => es.SubjectId == subjectId))
                        {
                            _agreementSubjectService.TInsert(new AgreementSubject
                            {
                                AgreementId = model.Id,
                                SubjectId = subjectId
                            });
                        }
                    }
                }

                return RedirectToAction("Index");
            }

            return PartialView("Edit", model);
        }

    }

}

