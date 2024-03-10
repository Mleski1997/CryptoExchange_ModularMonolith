using CryptoExchange.Modules.Wallets.Core.DTO;
using CryptoExchange.Modules.Wallets.Core.Entities;
using CryptoExchange.Modules.Wallets.Core.Exceptions;
using CryptoExchange.Modules.Wallets.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task<Wallet> GetWalletAsync(Guid id) =>  await _walletRepository.GetAsync(id);
       

        public async Task<IReadOnlyCollection<Wallet>> GetWalletsAsync() => await _walletRepository.GetAllAsync();
        
        public async Task AddAsync(WalletDto dto)
        {
           dto.Id = Guid.NewGuid();
            var wallet = new Wallet
            {
                Id = dto.Id,
             
                WalletName = dto.WalletName,
                CreatedAt = dto.CreatedAt,
                TotalSaldo = dto.TotalSaldo,
            };

            await _walletRepository.AddAsync(wallet);
        }

        public async Task DeleteAsync(Guid id)
        {
            var wallet = await _walletRepository.GetAsync(id);
            if(wallet is null)
            {
                throw new WalletNotFoundException(id);
            }
            await _walletRepository.DeleteAsync(wallet);

        }

        public async Task UpdateAsync(WalletUpdateDto dto)
        {
            var wallet = await _walletRepository.GetAsync(dto.Id);
            if (wallet is null)
            {
                throw new WalletNotFoundException(dto.Id);
            }
            wallet.WalletName = dto.WalletName;
            await _walletRepository.UpdateAsync(wallet);
         }
    }
}
