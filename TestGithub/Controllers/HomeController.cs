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
            _logger = logger;
        }

        public IActionResult Index()
        {
            int b = 0;
            return View();
        }

        public IActionResult Privacy()
        {
            int c = 0;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            int d = 0;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}