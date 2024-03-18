using CryptoExchange.Modules.Wallets.Api;
using CryptoExchange.Shared.Infrastructure;
using Bootstrapper.CryptoExchange;
using Microsoft.Extensions.Logging;
using System.Reflection;
using Microsoft.Graph.Education.Classes.Item.Modules;
using CryptoExchange.Shared.Abstractions.Modules;

namespace Boostrapper.CryptoExchange
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            IList<Assembly>  assemblies = ModuleLoader.LoadAssemblies(builder.Configuration);
            IList<IModule>  modules = ModuleLoader.LoadModules(assemblies);

          

            builder.Services.AddInfrastructure();

            foreach (var module in modules)
            {
                module.Register(builder.Services, builder.Configuration);
            }

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            
            
            var logger = app.Services.GetRequiredService<ILogger<Program>>();
            logger.LogInformation($"Modules: {string.Join(", ", modules.Select(x => x.Name))}");


            foreach (var module in modules)
            {
                module.Use(app);
            }



            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            assemblies.Clear();
            modules.Clear();

            app.Run();
        }
    }
}

