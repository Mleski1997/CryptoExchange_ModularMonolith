using CryptoExchange.Modules.Users.Core.Entities;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.Graph.Models;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace CryptoExchange.Modules.Wallets.Core.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string WalletAddress { get; set; }
        public string WalletName { get; set; } 
        public DateTime CreatedAt { get; set; }
        public decimal TotalSaldo { get; set; }

        public Wallet()
        {
            
            WalletAddress = GenerateWalletAddress();
            CreatedAt = DateTime.UtcNow;
            TotalSaldo = 0;
        }

        private string GenerateWalletAddress(int lenght = 8)
        {
           using (var randomNumberGenerator = RandomNumberGenerator.Create()) {
                var randomNumer = new byte[lenght];
                randomNumberGenerator.GetBytes(randomNumer);

                var hexString = BitConverter.ToString(randomNumer).Replace("-", "").ToLower();
                return hexString;
            
            }
        }

        
    }
}
