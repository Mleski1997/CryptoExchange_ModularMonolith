using CryptoExchange.Shared.Abstractions.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Messages.Events
{
    public record UserCreatedEvent(Guid Id, string UserName, string Email) : IEvent;
   
}