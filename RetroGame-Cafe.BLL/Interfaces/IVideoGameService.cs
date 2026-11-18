using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface IVideoGameService
    {
        IEnumerable<VideoGameModel> GetAll();

        IEnumerable<VideoGameModel> GetProductPerConsole(string console);

        VideoGameModel? GetById(int id);

        int CreatVideoGame(VideoGameModel data);

        bool UpdateVideoGame(int id, VideoGameModel product);

        bool DeleteVideoGame(int id);
    }
}
