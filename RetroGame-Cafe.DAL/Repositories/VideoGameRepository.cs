using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RetroGame_Cafe.DAL.Entities;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.DAL.Repositories
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly AppDbContext _context;

        public VideoGameRepository(AppDbContext context)
        {
            _context = context;
        }

        public int CreateVideoGame(VideoGameEntity data)
        {
            EntityEntry<VideoGameEntity> prod = _context.VideoGames.Add(data);

            _context.SaveChanges();

            return prod.Entity.Id;
        }

        public bool DeleteVideoGame(int id)
        {
            VideoGameEntity? prod = _context.VideoGames.SingleOrDefault(p => p.Id == id);

            if (prod is null)
            {
                return false;
            }

            _context.VideoGames.Remove(prod);
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<VideoGameEntity> GetAll()
        {
            return _context.VideoGames.Include(v => v.Console).ToList();
        }

        public VideoGameEntity? GetById(int id)
        {
            return _context.VideoGames.Include(v => v.Console).SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<VideoGameEntity> GetProductPerConsole(string console)
        {
            return _context.VideoGames.Include(v => v.Console).Where(p => p.Console.Name == console);
        }

        public bool UpdateVideoGame(int id, VideoGameEntity product)
        {
            VideoGameEntity prod = new VideoGameEntity()
            {
                Id = id,
                Title = product.Title,
                FK_Console_Id = product.Console.Id,
            };

            _context.Update(prod);
            _context.SaveChanges();

            return true;
        }
    }
}
