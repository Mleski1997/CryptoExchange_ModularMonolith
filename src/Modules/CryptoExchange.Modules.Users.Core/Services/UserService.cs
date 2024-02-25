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
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task AddAsync(RegisterDto registerDto)
        {
            var existEmail = await _userManager.FindByEmailAsync(registerDto.Email);
            if(existEmail != null)
            {
                throw new EmailAlreadyExistsExcpetion(registerDto.Email);
            }

            var User = new User()
            {
                Email = registerDto.Email,
                UserName = registerDto.Email

            };
           await _userManager.CreateAsync(User, registerDto.Password);

    
        }

        public Task<User> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
