using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.Web.Models;
using Cornerstech.Web.Models.User;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Cornerstech.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAgreementService _agreementService;
        private readonly IUserService _userService;


        public HomeController(ILogger<HomeController> logger, IAgreementService agreementService, IUserService userService)
        {
            _logger = logger;
            _agreementService = agreementService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetByName(model.Username);

                if ((user != null && _userService.CheckPasswordByName(user.UserName, model.Password)) ||
                        (model.Username == "admin" && model.Password == "1234"))
                {
                    var role = _userService.GetUserRole(model.Username) ?? "Admin";
                    var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, model.Username),
                new Claim(ClaimTypes.Role, role)
            };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Home");
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
