using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace CryptoExchange.Shared.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
           


            return services;

        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
                
            

            return app;
        }

        public static T GetOptions<T>(this IServiceCollection services, string sectionName) where T : new()
        {
            using var serviceProvider = services.BuildServiceProvider();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            return configuration.GetOptions<T>(sectionName);
        }

        public static T GetOptions<T>(this IConfiguration configuration, string sectionName) where T : new()
        {
            var options = new T();
            configuration.GetSection(sectionName).Bind(options);
            return options;
        } 

    }
}
