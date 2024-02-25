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
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IUserService _userRepository;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IUserService userRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
        }

        [HttpPost("register")]

        public async Task<IActionResult> Register(RegisterDto dto)
        {
            await _userRepository.AddAsync(dto);   
            return NoContent();
        }
    }
}
