using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace CryptoExchange.Modules.Users.Api.Controllers
{
    [Route(UserModule.BasePath)]
    public class HomeController : BaseController 

    {
        [HttpGet]
        public ActionResult<string> Get() => "Users Api";
    }
}
