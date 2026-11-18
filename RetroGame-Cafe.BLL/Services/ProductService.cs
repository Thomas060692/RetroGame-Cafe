using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class ProductService : IProductsService
    {
        private readonly IProductService _productService;

        public ProductService(IProductService productService)
        {
            _productService = productService;
        }

        public int CreatProduct(ProductModel data)
        {
            int id = _productService.CreatProduct(data.ToEntity());

            data.Id = id;
            return id;
        }

        public bool DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }

        public IEnumerable<ProductModel> GetAll()
        {
            return _productService.GetAll().Select(p => p.ToModel()).ToList();
        }

        public ProductModel? GetById(int id)
        {
            ProductModel? pro = _productService.GetById(id)?.ToModel();

            if (pro is null)
            {
                throw new Exception("ce produit n'existe pas");
            }

            return pro;
        }

        public IEnumerable<ProductModel> GetProductPerCategorie(string categorie)
        {
            return _productService.GetProductPerCategorie(categorie)
                                  .Select(p => p.ToModel()).ToList();
        }

        public bool UpdateProduct(int id, ProductModel product)
        {
            try
            {
                _productService.UpdateProduct(id, product.ToEntity());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
