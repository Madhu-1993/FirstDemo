using Microsoft.AspNetCore.Mvc;

namespace FirstDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
