using CryptoExchange.Modules.Users.Core.DAL;
using CryptoExchange.Modules.Users.Core.Entities;
using CryptoExchange.Modules.Users.Core.Repository;
using CryptoExchange.Modules.Users.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Users.Core
{
    public static class Extensions 
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UserDbContext>(options =>
           
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
           
           services.AddIdentity<User, IdentityRole>(options =>
               {
                   options.Password.RequireDigit = true;
                   options.Password.RequireLowercase = true;
                   options.Password.RequireUppercase = true;
                   options.Password.RequiredLength = 8;
               })
           .AddEntityFrameworkStores<UserDbContext>()
           .AddDefaultTokenProviders();

            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
