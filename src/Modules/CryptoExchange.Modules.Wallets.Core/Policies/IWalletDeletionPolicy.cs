using CryptoExchange.Modules.Wallets.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Policies
{
    public interface IWalletDeletionPolicy
    {
        Task<bool> CanDeletionWallet(Wallet wallet);
    }
}
