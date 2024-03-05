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
        Task<IReadOnlyList<User>> GetAllUsers();
        Task<User> GetById(string id);
        Task Update(User user);
        Task Delete(User user);
    }
}