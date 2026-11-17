using Microsoft.EntityFrameworkCore.ChangeTracking;
using RetroGame_Cafe.DAL.Entities;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.DAL.Repositories
{
    public class ConsolesRepository : IConsolesService
    {
        private readonly AppDbContext _context;

        public ConsolesRepository(AppDbContext context)
        {
            _context = context;
        }

        public int CreatConsole(ConsoleEntity data)
        {
            EntityEntry<ConsoleEntity> prod = _context.Consoles.Add(data);

            _context.SaveChanges();

            return prod.Entity.Id;
        }

        public bool DeleteConsole(int id)
        {
            ConsoleEntity? prod = _context.Consoles.SingleOrDefault(p => p.Id == id);

            if (prod is null)
            {
                return false;
            }

            _context.Consoles.Remove(prod);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<ConsoleEntity> GetAll()
        {
            return _context.Consoles.ToList();
        }

        public ConsoleEntity? GetById(int id)
        {
            return _context.Consoles.SingleOrDefault(p => p.Id == id);
        }

        public bool UpdateConsole(int id, ConsoleEntity product)
        {
            ConsoleEntity prod = new ConsoleEntity()
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
