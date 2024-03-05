using Microsoft.Extensions.DependencyInjection;
using CryptoExchange.Modules.Wallets.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddWallets(this IServiceCollection services)
        {
            services.AddCore();
            return services;
        }
    }
}
