using CryptoExchange.Modules.Wallets.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Policies
{
    public class WalletDeletionPolicy : IWalletDeletionPolicy
    {
        public async Task<bool> CanDeletionWallet(Wallet wallet)
        {
            if (wallet.TotalSaldo != 0)
            {
                return false;
            }
            return true;
        }
    }
}
