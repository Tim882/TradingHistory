using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class AccountDataService: BaseDataService<Account>, IAccountDataService
    {
        public AccountDataService(IRepository<Account> repository) : base(repository) { }
    }
}
