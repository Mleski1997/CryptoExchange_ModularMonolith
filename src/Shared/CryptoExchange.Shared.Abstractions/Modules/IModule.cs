using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CryptoExchange.Shared.Abstractions.Modules
{
    public interface IModule
    { 
        string Name { get; }
        string Path { get;}

        void Register(IServiceCollection services, IConfiguration configuration);
        void Use(IApplicationBuilder app);
    }
}
