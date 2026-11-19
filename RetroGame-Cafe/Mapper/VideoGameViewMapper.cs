using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Mapper
{
    internal static class VideoGameViewMapper
    {
        public static VideoGameViewModel ToVideoGameViewModel(this VideoGameModel model)
        {
            return new VideoGameViewModel()
            {
                Id = model.Id,
                Title = model.Title,
                ConsoleId = model.ConsoleId,
                ConsoleName = model.ConsoleName,
            };
        }

        public static VideoGameModel ToVideoGameModel(this VideoGameModel vgm)
        {
            return new VideoGameModel()
            {
                Id = vgm.Id,
                Title = vgm.Title,
                ConsoleId = vgm.ConsoleId,
                ConsoleName = vgm.ConsoleName,
            };
        }
    }
}
