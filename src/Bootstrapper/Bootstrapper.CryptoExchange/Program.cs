using CryptoExchange.Modules.Wallets.Api;
using CryptoExchange.Shared.Infrastructure;
using Bootstrapper.CryptoExchange;
using Microsoft.Extensions.Logging;

namespace Boostrapper.CryptoExchange
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddWallets(builder.Configuration);

            var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration);
            var modules = ModuleLoader.LoadModules(assemblies);




            foreach (var module in modules)
            {
                module.Register(builder.Services, builder.Configuration);
            }

    
            builder.Services.AddInfrastructure();

          

           

            
            var app = builder.Build();

            

            foreach (var module in modules)
            {
                module.Use(app);
            }

  
      
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

