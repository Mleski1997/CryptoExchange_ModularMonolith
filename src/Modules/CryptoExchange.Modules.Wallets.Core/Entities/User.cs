using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Entities
{
    public class User
    {
        public string UserId { get; set; }
        public bool IsActive { get; set; }
        public IList<Wallet> Wallets { get; set; }
    }
}
