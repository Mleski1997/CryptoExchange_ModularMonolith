using Microsoft.Extensions.DependencyInjection;
using CryptoExchange.Modules.Wallets.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CryptoExchange.Modules.Wallets.Core.Services;

namespace CryptoExchange.Modules.Wallets.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddWallets(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IWalletService,WalletService>();
            return services;
        }
    }
}
