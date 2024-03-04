using CryptoExchange.Modules.Wallets.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core.DAL.Configurations
{
    internal class WalletsConfigurations : IEntityTypeConfiguration<Wallet> 
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            throw new NotImplementedException();
        }
    }
}
