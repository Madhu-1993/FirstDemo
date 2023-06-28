using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace FirstDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<string> colors = new List<string>() {
            "Red","Blue","Green","White","Pink","Purple"
            };
            ViewData["Colors"] = colors;

            ViewData["message"] = "Hello from Controller";

            TempData["message"] = "This is tempdata";
            TempData.Keep("message");

            //viewbag
            ViewBag.Colors = colors;
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