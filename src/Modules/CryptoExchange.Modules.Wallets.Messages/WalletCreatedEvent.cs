using CryptoExchange.Shared.Abstractions.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Messages
{
    public record WalletCreatedEvent(Guid Id, string WalletAddress, string WalletName, DateTime CreatedAt, decimal TotalSaldo) : IEvent { }
   
}
