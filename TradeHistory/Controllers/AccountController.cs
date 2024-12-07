using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TradeHistory.Data.Interfaces;
using TradeHistory.Models;

namespace TradeHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : BaseController<Account>
    {
        public AccountController(IAccountDataService accountDataService) : base(accountDataService) { }
    }
}
