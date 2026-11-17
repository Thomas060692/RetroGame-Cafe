using RetroGame_Cafe.DAL.Entities;

namespace RetroGame_Cafe.DAL.Interface
{
    public interface IConsolesService
    {
        IEnumerable<ConsoleEntity> GetAll();

        ConsoleEntity? GetById(int id);

        int CreatConsole(ConsoleEntity data);

        bool UpdateConsole(int id, ConsoleEntity product);

        bool DeleteConsole(int id);
    }
}
