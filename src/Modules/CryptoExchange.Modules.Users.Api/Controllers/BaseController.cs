using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Api.Controllers
{
    [ApiController]
    [Route(UsersModule.BasePath + "/[controller]")]
    public class BaseController : ControllerBase
    {
        protected const string BasePath = "users-module";

        protected ActionResult<T> OkOrNotFound<T>(T model)
        {
            if (model is null)
            {
                return NotFound();
            }
            return Ok(model);
        }
    }
}
