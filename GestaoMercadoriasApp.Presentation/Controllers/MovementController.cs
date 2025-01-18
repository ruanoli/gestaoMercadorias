using Microsoft.AspNetCore.Mvc;

namespace GestaoMercadoriasApp.Presentation.Controllers
{
    public class MovementController : Controller
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
