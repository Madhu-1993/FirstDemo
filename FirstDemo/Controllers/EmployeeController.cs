using FirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult AddEmplyee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmplyee(Employee employee)
        {
            return View();
        }
    }
}
