using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cornerstech.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgreementService _agreementService;

        public HomeController(ILogger<HomeController> logger, IAgreementService agreementService)
        {
            _logger = logger;
            _agreementService = agreementService;
        }

        public IActionResult Index()
        {
            var agreementStatusCounts = _agreementService.GetAgreementStatusCounts();
            var monthlyAgreementCounts = _agreementService.GetMonthlyAgreementCounts();
            var industryAgreementCounts = _agreementService.GetIndustryAgreementCounts(); 

            ViewBag.AgreementStatusCounts = agreementStatusCounts;
            ViewBag.MonthlyAgreementCounts = monthlyAgreementCounts;
            ViewBag.IndustryAgreementCounts = industryAgreementCounts;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
