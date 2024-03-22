using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core.Entities
{
    public class Wallet
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
        public string WalletAddress { get; private set; }
        public string WalletName { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal TotalSaldo { get; set; }

        public Wallet()
        {

            WalletAddress = GenerateWalletAddress();
            CreatedAt = DateTime.UtcNow;
            TotalSaldo = 0;
        }

        private static string GenerateWalletAddress(int lenght = 8)
        {
            using (var randomNumberGenerator = RandomNumberGenerator.Create())
            {
                var randomNumer = new byte[lenght];
                randomNumberGenerator.GetBytes(randomNumer);

                var hexString = BitConverter.ToString(randomNumer).Replace("-", "").ToLower();
                return hexString;

            }
        }


    }
}