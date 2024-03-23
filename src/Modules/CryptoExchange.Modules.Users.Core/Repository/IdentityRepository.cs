using CryptoExchange.Modules.Users.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Repository
{
    public class IdentityRepository : IIdentityRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public IdentityRepository(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public Task AddRoleAsync(User User) => _userManager.AddToRoleAsync(User,"User");


        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
            return result.Succeeded;
        }


        public async Task CreateAsync(User user, string password) => await _userManager.CreateAsync(user, password);
       

        public async Task<User> FindByEmailAsync(string email) => await _userManager.FindByEmailAsync(email);


        public async Task<User> FindByNameAsync(string usernName) => await _userManager.FindByNameAsync(usernName);
       
    }
}
