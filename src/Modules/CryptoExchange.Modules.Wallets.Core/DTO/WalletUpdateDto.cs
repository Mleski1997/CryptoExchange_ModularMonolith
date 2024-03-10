using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.DTO
{
    public class WalletUpdateDto
    {
        public Guid Id { get; set; }
        public string WalletName { get; set; }
    }
}
