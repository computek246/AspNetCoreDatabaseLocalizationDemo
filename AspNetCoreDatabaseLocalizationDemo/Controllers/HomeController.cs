using System;
using AspNetCoreDatabaseLocalizationDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using AspNetCoreDatabaseLocalizationDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace AspNetCoreDatabaseLocalizationDemo.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(
            ILanguageService languageService,
            ILocalizationService localizationService,
            ILogger<HomeController> logger
            )
            : base(languageService, localizationService)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            ViewData["Title"] = Localize("customer.page.create.title");

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




        [HttpPost]
        public IActionResult ChangeLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddDays(7)
                }
            );

            return LocalRedirect(returnUrl);
        }

    }
}
