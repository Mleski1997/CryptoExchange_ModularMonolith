using CryptoExchange.Modules.Wallets.Core.DTO;
using CryptoExchange.Modules.Wallets.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Services
{
    public interface IWalletService
    {
        Task<Wallet> GetWalletAsync(Guid id);
        Task<IReadOnlyCollection<Wallet>> GetWalletsAsync();
        Task AddAsync(WalletDto dto);
        Task UpdateAsync(WalletUpdateDto dto);
        Task DeleteAsync(Guid id);


    }
}
