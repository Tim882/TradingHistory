using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class BaseDataService<T> : IBaseDataService<T> where T : BaseEntity
    {
        protected readonly IRepository<T> _repository;

        public BaseDataService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public bool Create(T entity)
        {
            return _repository.Create(entity);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }

        public T Get(long id)
        {
            return _repository.Get(id);
        }

        public List<T> Get()
        {
            return _repository.Get().ToList();
        }

        public bool Update(T entity)
        {
            return _repository.Update(entity);
        }
    }
}
