using CryptoExchange.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Exceptions
{
    public class CannotDeleteWalletException : CryptoExchangeException
    {
        public decimal saldo { get; set; }
        public CannotDeleteWalletException(decimal saldo) : base($"You cant delete wallet becouse you saldo is {saldo}") 
        {
            saldo = saldo;
           
        }
    }
}
