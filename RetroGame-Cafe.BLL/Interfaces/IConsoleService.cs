using RetroGame_Cafe.BLL.Models;

namespace RetroGame_Cafe.BLL.Interfaces
{
    public interface IConsoleService
    {
        IEnumerable<ConsoleModel> GetAll();

        ConsoleModel? GetById(int id);

        ConsoleModel CreatConsole(ConsoleModel data);

        bool UpdateConsole(int id, ConsoleModel product);

        bool DeleteConsole(int id);
    }
}
