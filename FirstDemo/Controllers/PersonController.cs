using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> options = new List<string>() { "Select Option", "Yes", "No" };
            ViewData["options"] = new SelectList(options);
            return View();
        }
        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form)
        {
            ViewBag.UserName = form["username"];
            ViewBag.Email = form["email"];
            ViewBag.Gender = form["gender"];
            ViewBag.Opetion = form["options"];
            return View("Details");
        }
    }
}
