using CryptoExchange.Modules.Users.Core.DAL;
using CryptoExchange.Modules.Wallets.Core.DAL;
using CryptoExchange.Modules.Wallets.Core.Repositories;
using CryptoExchange.Shared.Infrastructure.Postgres;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPostgres<WalletsDbContext>(configuration);
            services.AddScoped<IWalletRepository, WalletRepository>();

            return services;   
        }
    }
}
