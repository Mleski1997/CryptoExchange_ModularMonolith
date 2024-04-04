using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
       
        public IList<Wallet> Wallets { get; set; }
    }
}
