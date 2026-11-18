using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.BLL.Mapper
{
    internal static class CategorieMapper
    {
        public static CategorieEntity ToEntity(this CategorieModel data)
        {
            return new CategorieEntity()
            {
                Id = data.Id,
                Name = data.Name,
            };
        }

        public static CategorieModel ToModel(this CategorieEntity data)
        {
            return new CategorieModel()
            {
                Id = data.Id,
                Name = data.Name,
            };
        }
    }
}
