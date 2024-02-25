using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Shared.Abstractions.Exceptions
{
    public  class CryptoExchangeException : Exception
    {
        public CryptoExchangeException(string message) : base(message)
        {
            
        }
    }
}
