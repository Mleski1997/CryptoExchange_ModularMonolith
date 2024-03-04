using CryptoExchange.Modules.Wallets.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Repositories
{
    public interface IWalletRepository
    {
        Task<Wallet> GetAsync(Guid id);
        Task<IReadOnlyList<Wallet>> GetAllAsync();
        Task AddAsync(Wallet wallet);
        Task UpdateAsync(Wallet wallet);
        Task DeleteAsync(Wallet wallet);
        
    }
}
