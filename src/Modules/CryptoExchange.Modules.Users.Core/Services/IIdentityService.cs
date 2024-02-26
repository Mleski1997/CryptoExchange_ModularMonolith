using CryptoExchange.Modules.Users.Core.DTO;
using CryptoExchange.Modules.Users.Core.Entities;
using Microsoft.IdentityModel.JsonWebTokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Services
{
    public interface IIdentityService
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task SignUp(SignUpDto singUpDto);
        Task<JwtToken> SingIn(LoginD)
     
    }
}
