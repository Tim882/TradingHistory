using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : BaseController<Position>
    {
        public PositionController(IPositionDataService PositionDataService) : base(PositionDataService) { }
    }
}
