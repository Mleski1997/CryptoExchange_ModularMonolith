using CryptoExchange.Modules.Users.Core.DAL;
using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Exceptions;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<User> _signInManager;
      

        public IdentityService(UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
           
        }
        public async Task SignUpAsync(SignUpDto signUpDto)
        {
            var existEmail = await _userManager.FindByEmailAsync(signUpDto.Email);
            if(existEmail != null)
            {
                throw new EmailAlreadyExistsExcpetion(signUpDto.Email);
            }

            var existUserName = await _userManager.FindByEmailAsync(signUpDto.UserName);
            if(existUserName != null)
            {
                throw new UserNameAlreadyExistsException(signUpDto.UserName);
            }

            var User = new User()
            {
                Email = signUpDto.Email,
                UserName = signUpDto.UserName

            };
            await _userManager.CreateAsync(User, signUpDto.Password);
            await _userManager.AddToRoleAsync(User, "User");
        }
        public async Task<String> SignInAsync(SignInDto signInDto)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == signInDto.UserName);
            if (user is null)
            {
                throw new UserDoesntExistsExceptions(signInDto.UserName);
            }

            if(!user.IsActive) 
            {
                throw new UserIsNotActiveExcepetion(user.Id);
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, signInDto.Password, false);

            if (!result.Succeeded)
            {
                throw new WrongPasswordException();
            }


            return _tokenService.CreateToken(user);
        }

        
      
    }
}
