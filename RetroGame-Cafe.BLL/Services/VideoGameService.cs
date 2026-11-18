using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly IVidoeGameService _vidoeGame;

        public VideoGameService(IVidoeGameService vidoeGame)
        {
            _vidoeGame = vidoeGame;
        }

        public int CreatVideoGame(VideoGameModel data)
        {
            int id = _vidoeGame.CreatVideoGame(data.ToEntity());

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
                throw new Exception("ce jeux n'existe pas");
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
