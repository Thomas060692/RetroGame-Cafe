using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.Mapper;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Controllers
{
    public class ConsoleController : Controller
    {
        private readonly IConsoleService consoleService;

        public ConsoleController(IConsoleService consoleService)
        {
            this.consoleService = consoleService;
        }

        public IActionResult Index()
        {
            IEnumerable<ConsoleViewModel> cons = consoleService.GetAll().Select(c => c.ToConsoleViewModel()).ToList();

            return View(cons);
        }

        [Authorize(Roles = "Admin,Modo")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Modo")]
        public IActionResult Create([FromForm] ConsoleViewModel cf)
        {
            if (!ModelState.IsValid)
            {
                return View(cf);
            }

            consoleService.CreatConsole(cf.ToModel());

            return View();
        }


    }
}
