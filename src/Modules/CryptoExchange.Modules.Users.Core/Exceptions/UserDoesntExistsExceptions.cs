using CryptoExchange.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Exceptions
{
    public class UserDoesntExistsExceptions : CryptoExchangeException
    {
        public string UserName { get; set; }
        public UserDoesntExistsExceptions(string username) : base($"Invalid username `{username}`")
        {
            UserName = username;
            
        }
    }
}
