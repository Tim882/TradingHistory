using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class DealDataService: BaseDataService<Deal>, IDealDataService
    {
        public DealDataService(IRepository<Deal> repository) : base(repository) { }
    }
}
