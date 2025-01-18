using GestaoMercadoriasApp.Domain.Interfaces;
using GestaoMercadoriasApp.Domain.Models;
using GestaoMercadoriasApp.Presentation.ViewModels;
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
