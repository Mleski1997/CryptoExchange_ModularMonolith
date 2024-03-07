using CryptoExchange.Modules.Wallets.Core.DTO;
using CryptoExchange.Modules.Wallets.Core.Entities;
using CryptoExchange.Modules.Wallets.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Services
{
    public class ServiceWallet : IServiceWallet
    {
        private readonly IWalletRepository _walletRepository;

        public ServiceWallet(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public Task<Wallet> GetWalletAsync(Guid id) => _walletRepository.GetAsync(id);
       

        public async Task<IReadOnlyCollection<Wallet>> GetWalletsAsync() => await _walletRepository.GetAllAsync();
        
        public Task AddAsync(Wallet wallet)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(WalletUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
