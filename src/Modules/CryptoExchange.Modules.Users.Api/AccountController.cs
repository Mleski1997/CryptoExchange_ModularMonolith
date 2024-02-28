using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CryptoExchange.Modules.Users.Api
{
    [Route("api/acccount")]
    [ApiController]
    public class AccountController : ControllerBase
    {
       
        private readonly IIdentityService _identityService;

        public AccountController(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        [HttpPost("Register")]

        public async Task<IActionResult> Register(SignUpDto signUpDto)
        {
            await _identityService.SignUpAsync(signUpDto);   
            return NoContent();
        }

        [HttpPost("Login")]

        public async Task <IActionResult> Login(SignInDto signInDto) => Ok(await _identityService.SignInAsync(signInDto));
       
    }
}
