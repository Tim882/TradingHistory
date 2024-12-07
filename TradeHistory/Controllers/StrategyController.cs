using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StrategyController : BaseController<Strategy>
    {
        public StrategyController(IStrategyDataService StrategyDataService) : base(StrategyDataService) { }
    }
}
