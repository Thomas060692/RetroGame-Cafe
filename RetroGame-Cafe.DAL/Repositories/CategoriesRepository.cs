using Microsoft.EntityFrameworkCore.ChangeTracking;
using RetroGame_Cafe.DAL.Entities;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.DAL.Repositories
{
    public class CategoriesRepository : ICategoriesService
    {
        private readonly AppDbContext _context;

        public CategoriesRepository(AppDbContext context)
        {
            _context = context;
        }

        public int CreatCategory(CategorieEntity data)
        {
            EntityEntry<CategorieEntity> prod = _context.Categories.Add(data);

            _context.SaveChanges();

            return prod.Entity.Id;
        }

        public bool DeleteCategory(int id)
        {
            CategorieEntity? prod = _context.Categories.SingleOrDefault(p => p.Id == id);

            if (prod is null)
            {
                return false;
            }

            _context.Categories.Remove(prod);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<CategorieEntity> GetAll()
        {
            return _context.Categories.ToList();
        }

        public CategorieEntity? GetById(int id)
        {
            return _context.Categories.SingleOrDefault(p => p.Id == id);
        }

        public bool UpdateCategory(int id, CategorieEntity product)
        {
            CategorieEntity prod = new CategorieEntity()
            {
                Id = id,
                Name = product.Name,
            };

            _context.Update(prod);
            _context.SaveChanges();

            return true;
        }
    }
}
