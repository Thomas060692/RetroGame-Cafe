using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class ConsoleService : IConsoleService
    {
        private readonly IConsolesService _consolesService;

        public ConsoleService(IConsolesService consolesService)
        {
            _consolesService = consolesService;
        }

        public ConsoleModel CreatConsole(ConsoleModel data)
        {
            int id = _consolesService.CreatConsole(data.ToEntity());

            data.Id = id;
            return data;
        }

        public bool DeleteConsole(int id)
        {
            return _consolesService.DeleteConsole(id);
        }

        public IEnumerable<ConsoleModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ConsoleModel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateConsole(int id, ConsoleModel product)
        {
            throw new NotImplementedException();
        }
    }
}
