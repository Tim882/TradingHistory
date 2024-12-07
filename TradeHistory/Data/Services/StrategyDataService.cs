using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class StrategyDataService: BaseDataService<Strategy>, IStrategyDataService
    {
        public StrategyDataService(IRepository<Strategy> repository) : base(repository) { }
    }
}
