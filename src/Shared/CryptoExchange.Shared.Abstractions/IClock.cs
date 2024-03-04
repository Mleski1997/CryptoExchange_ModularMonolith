using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Shared.Abstractions
{
    public interface IClock
    {
        DateTime CurrentDate();
    }
}
