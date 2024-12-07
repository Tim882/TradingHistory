using TradeHistory.Models;

namespace TradeHistory.DbRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        public IQueryable<T> Get();
        public T Get(long id);
        public bool Create(T entity);
        public bool Update(T entity);
        public bool Delete(long id);
    }
}
