using Microsoft.AspNetCore.Mvc;
using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.Mapper;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Controllers
{
    public class VideoGameAndConsoleController : Controller
    {
        private readonly IVideoGameService videoGameService;

        public VideoGameAndConsoleController(IVideoGameService videoGameService)
        {
            this.videoGameService = videoGameService;
        }

        public IActionResult Index()
        {
            IEnumerable<VideoGameViewModel> games = videoGameService.GetAll().Select(g => g.ToVideoGameViewModel()).ToList();
            IEnumerable<string> consoles = games.Select(g => g.ConsoleName).Distinct().ToList();

            ViewData[nameof(consoles)] = consoles;

            return View(games);
        }
    }
}
