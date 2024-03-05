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


        Task SignUpAsync(SignUpDto signUpDto);
        Task<String> SignInAsync(SignInDto signInDto);

    }
}