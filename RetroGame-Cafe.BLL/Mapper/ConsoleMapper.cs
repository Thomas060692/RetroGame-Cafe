using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.BLL.Mapper
{
    internal static class ConsoleMapper
    {
        public static ConsoleModel ToModel(this ConsoleEntity entity)
        {
            return new ConsoleModel()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }

        public static ConsoleEntity ToEntity(this ConsoleModel entity)
        {
            return new ConsoleEntity()
            {
                Id = entity.Id,
                Name = entity.Name,
            };
        }
    }
}
