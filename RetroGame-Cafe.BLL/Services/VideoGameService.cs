using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Services
{
    public class VideoGameService : Interfaces.IVideoGameService
    {
        private readonly DAL.Interface.IVideoGameRepository _vidoeGame;

        public VideoGameService(DAL.Interface.IVideoGameRepository vidoeGame)
        {
            _vidoeGame = vidoeGame;
        }

        public int CreatVideoGame(VideoGameModel data)
        {
            int id = _vidoeGame.CreateVideoGame(data.ToEntity());

            data.Id = id;
            return id;
        }

        public bool DeleteVideoGame(int id)
        {
            return _vidoeGame.DeleteVideoGame(id);
        }

        public IEnumerable<VideoGameModel> GetAll()
        {
            return _vidoeGame.GetAll().Select(v => v.ToModel()).ToList();
        }

        public VideoGameModel? GetById(int id)
        {
            VideoGameModel? vid = _vidoeGame.GetById(id)?.ToModel();

            if (vid is null)
            {
                return null;
            }

            return vid;
        }

        public IEnumerable<VideoGameModel> GetProductPerConsole(string console)
        {
            return _vidoeGame.GetProductPerConsole(console)
                             .Select(v => v.ToModel()).ToList();
        }

        public bool UpdateVideoGame(int id, VideoGameModel videoGame)
        {
            try
            {
                _vidoeGame.UpdateVideoGame(id, videoGame.ToEntity());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
