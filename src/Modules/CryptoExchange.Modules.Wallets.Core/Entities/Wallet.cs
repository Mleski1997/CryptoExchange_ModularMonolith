using CryptoExchange.Modules.Users.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace CryptoExchange.Modules.Wallets.Core.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string? WalletAdress { get; set; }
        public string WalletName { get; set; } 
        public DateTime CreatedAt { get; set; }
        public double TotalSaldo { get; set; }
    }
}
