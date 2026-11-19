using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IProductRepository
    {
        IEnumerable<ProductEntity> GetAll();

        IEnumerable<ProductEntity> GetProductPerCategorie(string categorie);

        ProductEntity? GetById(int id);

        int CreateProduct(ProductEntity data);

        bool UpdateProduct(int id, ProductEntity product);

        bool DeleteProduct(int id);
    }
}
