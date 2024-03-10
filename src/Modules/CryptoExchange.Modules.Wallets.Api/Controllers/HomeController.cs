using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace CryptoExchange.Modules.Wallets.Api.Controllers
{
    [Route(WalletModule.BasePath)]
    internal class HomeController : BaseController

    {
        [HttpGet]
        public ActionResult<string> Get() => "Wallet Api";
    }
}
