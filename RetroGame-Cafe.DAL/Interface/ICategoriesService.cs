using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface ICategoriesService
    {
        IEnumerable<CategorieEntity> GetAll();

        CategorieEntity? GetById(int id);

        int CreatCategory(CategorieEntity data);

        bool UpdateCategory(int id, CategorieEntity product);

        bool DeleteCategory(int id);
    }
}
