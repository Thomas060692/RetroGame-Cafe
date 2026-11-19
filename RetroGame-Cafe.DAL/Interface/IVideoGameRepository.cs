using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IVideoGameRepository
    {
        IEnumerable<VideoGameEntity> GetAll();

        IEnumerable<VideoGameEntity> GetProductPerConsole(string console);

        VideoGameEntity? GetById(int id);

        int CreateVideoGame(VideoGameEntity data);

        bool UpdateVideoGame(int id, VideoGameEntity product);

        bool DeleteVideoGame(int id);
    }
}
