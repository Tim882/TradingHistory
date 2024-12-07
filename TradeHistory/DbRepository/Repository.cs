using DataLayer.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.DbRepository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly HistoryDbContext _context;

        public Repository(HistoryDbContext context)
        {
            _context = context;
        }

        public bool Create(T entity)
        {
            _context.Set<T>().Add(entity);

            return SaveChanges();
        }

        public bool Delete(long id)
        {
            _context.Set<T>().Remove(Get(id));

            return SaveChanges();
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>();
        }

        public T Get(long id)
        {
            return _context.Set<T>().First(e => e.Id == id);
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);

            return SaveChanges();
        }

        private bool SaveChanges()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
