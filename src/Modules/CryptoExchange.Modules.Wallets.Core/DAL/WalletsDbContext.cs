using CryptoExchange.Modules.Wallets.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.DAL
{
    public class WalletsDbContext : DbContext
    {
        public DbSet<Wallet> Wallets { get; set; }

        public WalletsDbContext()
        {
            
        }
        public WalletsDbContext(DbContextOptions<WalletsDbContext> options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.HasDefaultSchema("wallet");
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
