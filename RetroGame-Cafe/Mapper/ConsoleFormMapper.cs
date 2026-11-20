using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.Models;

namespace RetroGame_Cafe.Mapper
{
    internal static class ConsoleFormMapper
    {
        public static ConsoleModel ToModel(this ConsoleViewModel cvm)
        {
            return new ConsoleModel()
            {
                Id = cvm.Id,
                Name = cvm.Name,
            };
        }
        public static ConsoleViewModel ToModel(this ConsoleModel model)
        {
            return new ConsoleViewModel()
            {
                Id = model.Id,
                Name = model.Name,
            };
        }
    }
}
