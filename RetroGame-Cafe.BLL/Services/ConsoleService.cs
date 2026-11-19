using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class ConsoleService : IConsoleService
    {
        private readonly IConsolesRepository _consolesService;

        public ConsoleService(IConsolesRepository consolesService)
        {
            _consolesService = consolesService;
        }

        public ConsoleModel CreatConsole(ConsoleModel data)
        {
            int id = _consolesService.CreateConsole(data.ToEntity());

            data.Id = id;
            return data;
        }

        public bool DeleteConsole(int id)
        {
            return _consolesService.DeleteConsole(id);
        }

        public IEnumerable<ConsoleModel> GetAll()
        {
            return _consolesService.GetAll().Select(c => c.ToModel()).ToList();
        }

        public ConsoleModel? GetById(int id)
        {
            ConsoleModel? con = _consolesService.GetById(id)?.ToModel();

            if (con is null)
            {
                return null;
            }

            return con;
        }

        public bool UpdateConsole(int id, ConsoleModel data)
        {
            try
            {
                _consolesService.UpdateConsole(id, data.ToEntity());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
