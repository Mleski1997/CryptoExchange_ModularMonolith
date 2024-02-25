using CryptoExchange.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Exceptions
{
    public class EmailAlreadyExistsExcpetion : CryptoExchangeException
    {
        public string Email { get; set; }
        public EmailAlreadyExistsExcpetion(string email) : base($"Email `{email} is already exists ")
        {
            Email = email;
        }
    }
}
