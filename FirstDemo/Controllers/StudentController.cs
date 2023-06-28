using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudents()
        {
            List<string> options = new List<string> { "Select City", "Akola", "Amaravti", "Pune", "Mumbai" };
            ViewData["options"]=new SelectList(options);
            return View();
        }
    }
}
