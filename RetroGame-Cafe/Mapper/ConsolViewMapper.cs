using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Mapper
{
    internal static class ConsolViewMapper
    {
        public static ConsoleViewModel ToConsoleViewModel(this ConsoleModel model)
        {
            return new ConsoleViewModel()
            {
                Id = model.Id,
                Name = model.Name,
            };
        }

        public static ConsoleModel ToConsoleViewModel(this ConsoleViewModel cvm)
        {
            return new ConsoleModel()
            {
                Id = cvm.Id,
                Name = cvm.Name,
            };
        }
    }
}
