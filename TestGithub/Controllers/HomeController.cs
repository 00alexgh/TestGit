using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestGithub.Models;

namespace TestGithub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            int a = 0;
            bool b = true;
            _logger = logger;
        }

        public IActionResult Index()
        {
            int b = 0;
            bool c = true;
            return View();
        }

        public IActionResult Privacy()
        {
            int c = 0;
            bool d = true;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            int d = 0;
            bool e = true;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}