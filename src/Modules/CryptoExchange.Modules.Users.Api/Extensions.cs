using CryptoExchange.Modules.Users.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddUsers(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCore(configuration);
            return services;
        }
        
    }
}
