using TradeHistory.Models;

namespace TradeHistory.Data.Interfaces
{
    public interface IBaseDataService<T> where T : BaseEntity
    {
        T Get(long id);
        List<T> Get();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(long id);
    }
}
