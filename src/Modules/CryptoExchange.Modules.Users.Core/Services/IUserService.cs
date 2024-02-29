using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Services
{
    public interface IUserService
    {
        Task<IReadOnlyList<UserDto>> GetAllUsers();
        Task<UserDto> GetById(string id);
    }
}
