using CryptoExchange.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Tokens.Api.Controllers
{
    public class TokensModule : IModule
    {
        public const string BasePath = "tokens-module";
        public string Name => "Tokens";

        public string Path => BasePath;

        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            
        }

        public void Use(IApplicationBuilder app)
        {
            throw new NotImplementedException();
        }
    }
}
