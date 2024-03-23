using CryptoExchange.Modules.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Repository
{
    public interface IIdentityRepository
    {
        Task<User> FindByEmailAsync(string email);
        Task<User> FindByNameAsync(string userName);
        Task AddRoleAsync(User User);
        Task CreateAsync(User user, string password);
        Task<bool> CheckPasswordAsync(User user, string password);

    }
}
