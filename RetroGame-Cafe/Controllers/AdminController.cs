using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RetroGame_Cafe.Controllers
{
    [Authorize(Roles = "Admin, Modo")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Console()
        {
            return RedirectToAction("Index", "Console");
        }

        public IActionResult VideoGame()
        {
            return View();
        }

        public IActionResult Product()
        {
            return RedirectToAction("Index", "Menu");
        }

        public IActionResult Categorie()
        {
            return View();
        }
    }
}
