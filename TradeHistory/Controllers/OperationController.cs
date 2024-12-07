using DataLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : BaseController<Operation>
    {
        public OperationController(IOperationDataService operationDataService) : base(operationDataService) { }
    }
}
