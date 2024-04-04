using CryptoExchange.Modules.Wallets.Core.DTO;
using CryptoExchange.Modules.Wallets.Core.Entities;
using CryptoExchange.Modules.Wallets.Core.Exceptions;
using CryptoExchange.Modules.Wallets.Core.Policies;
using CryptoExchange.Modules.Wallets.Core.Repositories;

namespace CryptoExchange.Modules.Wallets.Core.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;
        private readonly IWalletDeletionPolicy _walletDeletionPolicy;

        public WalletService(IWalletRepository walletRepository, IWalletDeletionPolicy walletDeletionPolicy)
        {
            _walletRepository = walletRepository;
            _walletDeletionPolicy = walletDeletionPolicy;
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
            if(await _walletDeletionPolicy.CanDeletionWallet(wallet) is false)
            {
                throw new CannotDeleteWalletException(wallet.TotalSaldo);
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
