using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.BLL.Mapper
{
    internal static class VideoGameMapper
    {
        public static VideoGameEntity ToEntity(this VideoGameModel videoGame)
        {
            return new VideoGameEntity()
            {
                Id = videoGame.Id,
                Title = videoGame.Title,
                FK_Console_Id = videoGame.ConsoleId,
            };
        }

        public static VideoGameModel ToModel(this VideoGameEntity videoGame)
        {
            return new VideoGameModel()
            {
                Id = videoGame.Id,
                Title = videoGame.Title,
                ConsoleId = videoGame.Console.Id,
                ConsoleName = videoGame.Console.Name,
            };
        }
    }
}
