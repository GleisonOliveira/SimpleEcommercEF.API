using eCommerce.Models;

namespace eCommerce.API.Repositories.Interfaces
{
    public interface IRepository<TModel>
    {
        public List<TModel> Get();
        public TModel? GetById(int id);
        public void Add(TModel obj);
        public void Update(TModel obj);
        public void Delete(TModel obj);
    }
}
