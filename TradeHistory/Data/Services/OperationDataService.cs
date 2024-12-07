using DataLayer.Models;
using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class OperationDataService: BaseDataService<Operation>, IOperationDataService
    {
        public OperationDataService(IRepository<Operation> repository) : base(repository) { }
    }
}
