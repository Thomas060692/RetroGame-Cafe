using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Mapper
{
    internal static class ProductViewModelMapper
    {
        public static ProductViewModel ToViewModel(this ProductModel model)
        {
            return new ProductViewModel()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description ?? "N/A",
                Price = model.Price,
                IsVegie = model.IsVegie,
                CategorieId = model.CategorieId,
                CategorieName = model.CategorieName,
            };
        }

        public static ProductModel ToModel(this ProductViewModel pvm)
        {
            return new ProductModel()
            {
                Id = pvm.Id,
                Name = pvm.Name,
                Description = pvm.Description,
                Price = pvm.Price,
                IsVegie = pvm.IsVegie,
                CategorieId = pvm.CategorieId,
                CategorieName = pvm.CategorieName,
            };
        }
    }
}
