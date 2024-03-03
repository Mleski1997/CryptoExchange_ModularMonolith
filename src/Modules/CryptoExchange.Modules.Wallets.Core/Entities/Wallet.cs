using CryptoExchange.Modules.Users.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        [Required]
        public string WalletAdress { get; set; }
        public string WalletName { get; set; }
        public DateTime CreatedAt { get; set; }
        public double TotalSaldo { get; set; }

        public ICollection<Token> Tokens { get; set; }
        public ICollection<Transfer> Transfers { get; set; }

    }
}
