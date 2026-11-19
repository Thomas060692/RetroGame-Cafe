using RetroGame_Cafe.BLL.Interfaces;
using RetroGame_Cafe.BLL.Mapper;
using RetroGame_Cafe.BLL.Models;
using RetroGame_Cafe.DAL.Interface;

namespace RetroGame_Cafe.BLL.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ICategoriesRepository _service;

        public CategorieService(ICategoriesRepository service)
        {
            _service = service;
        }

        public CategorieModel CreatCategory(CategorieModel data)
        {
            int id = _service.CreateCategory(data.ToEntity());

            data.Id = id;
            return data;
        }

        public bool DeleteCategory(int id)
        {
            return _service.DeleteCategory(id);
        }

        public IEnumerable<CategorieModel> GetAll()
        {
            return _service.GetAll().Select(c => c.ToModel()).ToList();
        }

        public CategorieModel? GetById(int id)
        {
            CategorieModel? cat = _service.GetById(id)?.ToModel();

            if (cat is null)
            {
                return null;
            }

            return cat;
        }

        public bool UpdateCategory(int id, CategorieModel product)
        {
            try
            {
                _service.UpdateCategory(id, product.ToEntity());
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
