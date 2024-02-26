using CryptoExchange.Modules.Users.Core.DAL;
using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Exceptions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public IdentityService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task SignUpAsync(SignUpDto signUpDto)
        {
            var existEmail = await _userManager.FindByEmailAsync(signUpDto.Email);
            if(existEmail != null)
            {
                throw new EmailAlreadyExistsExcpetion(signUpDto.Email);
            }

            var existUserName = await _userManager.FindByNameAsync(signUpDto.UserName);
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

        }
        public async Task SignInAsync(SignInDto signInDto)
        {
            var user = await _userManager.FindByLoginAsync(signInDto.UserName);
            if (user is null)
            {
                throw new UserDoesntExists(signUpDto.UserName);
            }


          
        }

        
        
    }
}
