using CryptoExchange.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Exceptions
{
    public class UserNameAlreadyExistsException : CryptoExchangeException
    {
        public string UserName { get; set; }
        public UserNameAlreadyExistsException(string username) : base($"Email `{username} is already exists ")
        {
            UserName = username;
        }
    }
}
