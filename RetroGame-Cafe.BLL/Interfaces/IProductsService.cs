using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<ProductModel> GetAll();

        IEnumerable<ProductModel> GetProductPerCategorie(string categorie);

        ProductModel? GetById(int id);

        int CreatProduct(ProductModel data);

        bool UpdateProduct(int id, ProductModel product);

        bool DeleteProduct(int id);
    }
}
