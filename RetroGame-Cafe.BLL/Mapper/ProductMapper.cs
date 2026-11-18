using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.BLL.Mapper
{
    internal static class ProductMapper
    {
        public static ProductEntity ToEntity(this ProductModel model)
        {
            return new ProductEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                IsVegie = model.IsVegie,
                Price = model.Price,
                Fk_Categorie_Id = model.CategorieId,
            };
        }

        public static ProductModel ToModel(this ProductEntity entity)
        {
            return new ProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                IsVegie = entity.IsVegie,
                Price = entity.Price,
                CategorieId = entity.Fk_Categorie_Id,
                CategorieName = entity.Categorie.Name,
            };
        }
    }
}
