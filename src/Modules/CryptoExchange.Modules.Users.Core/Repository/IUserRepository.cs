using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserById(string id);
        Task<IReadOnlyList<User>> GetAllUsers();
        Task UpdateAsync(User user);
        Task DeleteAsync(User user);

    }
}
