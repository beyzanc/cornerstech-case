using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cornerstech.Web.Controllers
{
    public class RiskController : Controller
    {
        private readonly IRiskService _riskService;
        private readonly IRiskCategoryService _riskCategoryService;

        public RiskController(IRiskService riskService, IRiskCategoryService riskCategoryService)
        {
            _riskService = riskService;
            _riskCategoryService = riskCategoryService;
        }

        public IActionResult Index(string sortOrder = "Name", string sortDirection = "asc")
        {
            var risks = _riskService.TGetList().ToList();


            risks = sortOrder switch
            {
                "Name" => (sortDirection == "asc" ? risks.OrderBy(a => a.Name) : risks.OrderByDescending(a => a.Name)).ToList(),
                "Level" => (sortDirection == "asc" ? risks.OrderBy(a => a.Level) : risks.OrderByDescending(a => a.Level)).ToList(),
                "Frequence" => (sortDirection == "asc" ? risks.OrderBy(a => a.Frequence) : risks.OrderByDescending(a => a.Frequence)).ToList(),
                "Possibility" => (sortDirection == "asc" ? risks.OrderBy(a => a.Possibility) : risks.OrderByDescending(a => a.Possibility)).ToList(),

            };

            return View(risks);
        }

    }
}
