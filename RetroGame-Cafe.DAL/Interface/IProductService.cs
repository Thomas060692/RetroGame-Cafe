using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IProductService
    {
        IEnumerable<ProductEntity> GetAll();

        IEnumerable<ProductEntity> GetProductPerCategorie(string categorie);

        ProductEntity? GetById(int id);

        int CreatProduct(ProductEntity data);

        bool UpdateProduct(int id, ProductEntity product);

        bool DeleteProduct(int id);
    }
}
