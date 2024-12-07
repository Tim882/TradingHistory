using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class PositionDataService: BaseDataService<Position>, IPositionDataService
    {
        public PositionDataService(IRepository<Position> repository) : base(repository) { }
    }
}
