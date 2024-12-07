using TradeHistory.Data.Interfaces;
using TradeHistory.DbRepository;
using TradeHistory.Models;

namespace TradeHistory.Data.Services
{
    public class InstrumentDataService: BaseDataService<Instrument>, IInstrumentDataService
    {
        public InstrumentDataService(IRepository<Instrument> repository) : base(repository) { }
    }
}
