using CryptoExchange.Shared.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Shared.Infrastructure
{
    public class UtcClock : IClock
    {
        public DateTime CurrentDate() => DateTime.UtcNow;
        
    }
}
