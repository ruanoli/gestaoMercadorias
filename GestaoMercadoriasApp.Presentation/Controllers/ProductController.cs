using Microsoft.AspNetCore.Mvc;

namespace GestaoMercadoriasApp.Presentation.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
