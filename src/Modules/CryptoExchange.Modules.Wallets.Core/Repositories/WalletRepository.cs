﻿using CryptoExchange.Modules.Wallets.Core.DAL;
using CryptoExchange.Modules.Wallets.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly WalletsDbContext _dbContext;
        private readonly DbSet<Wallet> _wallets;

        public WalletRepository(WalletsDbContext dbContext)
        {
            _dbContext = dbContext;
            _wallets = _dbContext.Wallets;
        }

        public async Task<Wallet> GetAsync(Guid id) => await _wallets.SingleOrDefaultAsync(x => x.Id == id);
       

        public async Task<IReadOnlyList<Wallet>> GetAllAsync() => await _wallets.ToListAsync();
       
        public async Task AddAsync(Wallet wallet)
        {
            await _wallets.AddAsync(wallet);
            await _dbContext.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(Wallet wallet)
        {
            _wallets.Remove(wallet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Wallet wallet)
        {
            _wallets.Update(wallet);
            await _dbContext.SaveChangesAsync();
        }
    }
}
