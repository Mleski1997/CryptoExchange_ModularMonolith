using CryptoExchange.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Exceptions
{
    public class UserIsNotActiveExcepetion : CryptoExchangeException
    {
        public string Id { get; set; }
        public UserIsNotActiveExcepetion(string id) : base ($"User with ID `{id}` is not active")
        {
            Id = id;   
        }
    }
}
