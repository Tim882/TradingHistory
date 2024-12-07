using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealController : BaseController<Deal>
    {
        public DealController(IDealDataService DealDataService) : base(DealDataService) { }
    }
}
