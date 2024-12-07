using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : BaseController<Instrument>
    {
        public InstrumentController(IInstrumentDataService InstrumentDataService) : base(InstrumentDataService) { }
    }
}
