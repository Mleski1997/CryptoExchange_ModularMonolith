using CryptoExchange.Modules.Wallets.Core;
using CryptoExchange.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoExchange.Modules.Wallets.Api
{
    internal class WalletModule : IModule
    {
        public const string BasePath = "wallet-module";
        public string Name => "Wallet";

        public string Path => BasePath;

        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddCore(configuration);
        }

        public void Use(IApplicationBuilder app)
        {

        }
    }
}
