using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IVidoeGameService
    {
        IEnumerable<VideoGameEntity> GetAll();

        IEnumerable<VideoGameEntity> GetProductPerConsole(string console);

        VideoGameEntity? GetById(int id);

        int CreatVideoGame(VideoGameEntity data);

        bool UpdateVideoGame(int id, VideoGameEntity product);

        bool DeleteVideoGame(int id);
    }
}
