using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface ICategorieService
    {
        IEnumerable<CategorieModel> GetAll();

        CategorieModel? GetById(int id);

        CategorieModel CreatCategory(CategorieModel data);

        bool UpdateCategory(int id, CategorieModel product);

        bool DeleteCategory(int id);
    }
}
