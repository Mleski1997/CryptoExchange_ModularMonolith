using CryptoExchange.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Exceptions
{
    internal class WalletNotFoundException : CryptoExchangeException
    {
        public Guid id { get; set; }
        public WalletNotFoundException(Guid id) : base($"Wallet Id {id} not found")
        {
            id = id;
        
        }
    }
}
