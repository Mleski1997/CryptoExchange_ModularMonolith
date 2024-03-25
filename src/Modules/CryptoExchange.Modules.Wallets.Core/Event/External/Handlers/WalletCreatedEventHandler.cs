using CryptoExchange.Modules.Wallets.Core.Entities;
using CryptoExchange.Modules.Wallets.Core.Repositories;
using CryptoExchange.Modules.Wallets.Messages;
using CryptoExchange.Shared.Abstractions.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Event.External.Handlers
{
    public class WalletCreatedEventHandler : IEventHandler<WalletCreatedEvent>
    {
        private readonly IWalletRepository _walletRepository;

        public WalletCreatedEventHandler(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }
        public Task HandleAsync(WalletCreatedEvent @event)
        {
            var wallet = new Wallet
            {
                Id = @event.Id,
                WalletName = @event.WalletName,
                WalletAddress = @event.WalletAddress,
                CreatedAt = @event.CreatedAt,
                TotalSaldo = @event.TotalSaldo
            };
        }
    }
}
