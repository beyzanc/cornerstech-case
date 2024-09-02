using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.Web.Models.Risk;
using Microsoft.AspNetCore.Mvc;

namespace Cornerstech.Web.Controllers
{
    public class RiskController : Controller
    {
        private readonly IRiskService _riskService;
        private readonly IRiskManagementService _riskManagementService;

        public RiskController(IRiskService riskService, IRiskManagementService riskManagementService)
        {
            _riskService = riskService;
            _riskManagementService = riskManagementService;
        }

        public IActionResult Index(string term = "", string sortOrder = "Name", string sortDirection = "asc")
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.CurrentSortDirection = sortDirection == "asc" ? "desc" : "asc";

            var risks = _riskService.TGetList()
                        .Where(r => string.IsNullOrEmpty(term) || r.Name.ToLower().Contains(term))
                        .ToList();

            risks = sortOrder switch
            {
                "Name" => (sortDirection == "asc" ? risks.OrderBy(a => a.Name) : risks.OrderByDescending(a => a.Name)).ToList(),
                "Category" => (sortDirection == "asc" ? risks.OrderBy(a => a.Category) : risks.OrderByDescending(a => a.Category)).ToList(),
                "Level" => (sortDirection == "asc" ? risks.OrderBy(a => a.Level) : risks.OrderByDescending(a => a.Level)).ToList(),
                "Frequence" => (sortDirection == "asc" ? risks.OrderBy(a => a.Frequence) : risks.OrderByDescending(a => a.Frequence)).ToList(),
                "Possibility" => (sortDirection == "asc" ? risks.OrderBy(a => a.Possibility) : risks.OrderByDescending(a => a.Possibility)).ToList(),
                _ => risks.ToList()
            };

            return View(risks);
        }

        public IActionResult RiskManagement()
        {
            var riskLevels = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Seviye")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var riskFrequencies = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Frekans")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var riskPossibilities = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Olasılık")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var viewModel = new RiskManagementViewModel
            {
                LevelDescriptions = riskLevels,
                FrequenceDescriptions = riskFrequencies,
                PossibilityDescriptions = riskPossibilities
            };

            return View(viewModel);
        }

        // GET: Risk/Create
        public IActionResult Create()
        {
            var riskLevels = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Seviye")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var riskFrequencies = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Frekans")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var riskPossibilities = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Olasılık")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var viewModel = new RiskCreateViewModel
            {
                LevelOptions = riskLevels,
                FrequenceOptions = riskFrequencies,
                PossibilityOptions = riskPossibilities
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RiskCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var risk = new Risk
                {
                    Name = model.Name,
                    Level = model.SelectedLevel,
                    Frequence = model.SelectedFrequence,
                    Possibility = model.SelectedPossibility,
                    Category = model.Category
                };

                _riskService.TInsert(risk);

                return RedirectToAction(nameof(Index));
            }

            var riskLevels = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Seviye")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var riskFrequencies = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Frekans")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            var riskPossibilities = _riskManagementService.TGetList()
                .Where(r => r.RiskCategory == "Olasılık")
                .ToDictionary(r => (double)r.RiskValue, r => r.RiskDescription);

            model.LevelOptions = riskLevels;
            model.FrequenceOptions = riskFrequencies;
            model.PossibilityOptions = riskPossibilities;

            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var risk = _riskService.TGetByID(id);
            if (risk == null)
            {
                return NotFound("Risk bulunamadı.");
            }

            _riskService.TDelete(risk);

            return RedirectToAction("Index");
        }


    }
}
