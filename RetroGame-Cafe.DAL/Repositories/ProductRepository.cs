using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RetroGame_Cafe.DAL.Entities;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public int CreateProduct(ProductEntity data)
        {
            EntityEntry<ProductEntity> prod = _context.Products.Add(data);

            _context.SaveChanges();

            return prod.Entity.Id;
        }

        public bool DeleteProduct(int id)
        {
            ProductEntity? prod = _context.Products.SingleOrDefault(p => p.Id == id);

            if (prod is null)
            {
                return false;
            }

            _context.Products.Remove(prod);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<ProductEntity> GetAll()
        {
            return _context.Products.Include(p => p.Categorie).ToList();
        }

        public IEnumerable<ProductEntity> GetProductPerCategorie(string categorie)
        {
            return _context.Products.Include(p => p.Categorie).Where(p => p.Categorie.Name == categorie);
        }

        public ProductEntity? GetById(int id)
        {
            return _context.Products.Include(p => p.Categorie).SingleOrDefault(p => p.Id == id);
        }

        public bool UpdateProduct(int id, ProductEntity product)
        {
            ProductEntity? pro = _context.Products.Find(id);

            if (pro is null)
            {
                return false;
            }

            pro.Name = product.Name;
            pro.Description = product.Description;
            pro.Price = product.Price;
            pro.IsVegie = product.IsVegie;
            pro.Fk_Categorie_Id = product.Fk_Categorie_Id;

            _context.SaveChanges();

            return true;
        }
    }
}
