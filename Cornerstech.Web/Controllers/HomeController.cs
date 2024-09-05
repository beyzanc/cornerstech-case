using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.Web.Models.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Cornerstech.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgreementService _agreementService;
        private readonly IUserService _userService;
        private readonly IAgreementPartnerService _agreementPartnerService;
        private readonly IRiskManagementService _riskManagementService;


        public HomeController(ILogger<HomeController> logger, IAgreementService agreementService, IUserService userService, 
                                IAgreementPartnerService agreementPartnerService, IRiskManagementService riskManagementService)
        {
            _logger = logger;
            _agreementService = agreementService;
            _userService = userService;
            _agreementPartnerService = agreementPartnerService;
            _riskManagementService = riskManagementService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model) // Handles login attempts, validating the user's credentials

        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetByName(model.Username);

                // Checks if the user credentials are valid, including the default admin login
                if ((user != null && _userService.CheckPasswordByName(user.UserName, model.Password)) ||
                        (model.Username == "admin" && model.Password == "1234"))
                {
                    // Creates claims for the user based on their 
                    var role = _userService.GetUserRole(model.Username) ?? "Admin";
                    var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Username),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // Signs in the user with the created 
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                    // Redirects the user based on their role
                    if (role == "Admin")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else if (role == "Partner")
                    {
                        return RedirectToAction("Index", "Agreement");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kullanýcý adý veya parola hatalý.");
                }
            }

            return View(model);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index() // Admin-only dashboard, provides statistical data for agreements, partners, and risks
        {
            var agreementStatusCounts = _agreementService.GetAgreementStatusCounts();
            var monthlyAgreementCounts = _agreementService.GetMonthlyAgreementCounts();
            var industryAgreementCounts = _agreementService.GetIndustryAgreementCounts();
            var totalAgreementCountInCurrentYear = _agreementService.GetTotalAgreementCountInCurrentYear();
            var partnerCountWithAgreements = _agreementPartnerService.GetPartnerCountWithAgreements();
            var riskScoreAverage = _riskManagementService.CalculateAverageScore();

            ViewBag.AgreementStatusCounts = agreementStatusCounts;
            ViewBag.MonthlyAgreementCounts = monthlyAgreementCounts;
            ViewBag.IndustryAgreementCounts = industryAgreementCounts;
            ViewBag.TotalAgreementCountInCurrentYear = totalAgreementCountInCurrentYear;
            ViewBag.PartnerCountWithAgreements = partnerCountWithAgreements;
            ViewBag.RiskScoreAverage = riskScoreAverage;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout() // Logout the user and redirects them to the login page

        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Home");
        }

    }
}
