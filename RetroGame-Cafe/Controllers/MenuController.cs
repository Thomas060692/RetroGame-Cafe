using Microsoft.AspNetCore.Mvc;
using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.Mapper;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Controllers
{
    public class MenuController : Controller
    {
        private readonly IProductsService productsService;

        public MenuController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductViewModel> data = productsService.GetAll().Select(p => p.ToViewModel()).ToList();

            ViewBag.Categories = data.Select(c => c.CategorieName).Distinct().ToList();

            return View(data);
        }
    }
}
