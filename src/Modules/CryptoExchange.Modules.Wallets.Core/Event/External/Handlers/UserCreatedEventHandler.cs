using CryptoExchange.Modules.Users.Core.Repository;
using CryptoExchange.Modules.Users.Messages.Events;
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
    internal class UserCreatedEventHandler : IEventHandler<UserCreatedEvent>
    {
        private readonly IIdentityRepository _identityRepository;

        public UserCreatedEventHandler(IIdentityRepository identityRepository)
        {
            _identityRepository = identityRepository;
        }
        public async Task HandleAsync(UserCreatedEvent @event)
        {
            var user = new User
            {
                UserId = @event.Id,
                UserName = @event.UserName,
            };

            await _identityRepository.CreateAsync(user,password)
            
        }
    }
}
