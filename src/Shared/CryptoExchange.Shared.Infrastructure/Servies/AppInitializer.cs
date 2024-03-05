﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Shared.Infrastructure.Servies
{
    internal class AppInitializer : IHostedService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger _logger;

        public AppInitializer(IServiceProvider serviceProvider, ILogger<AppInitializer> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        public ILogger<AppInitializer> Logger { get; }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            var dbContextTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(DbContext).IsAssignableFrom(x) && !x.IsInterface && x != typeof(DbContext));

            using var scoper = _serviceProvider.CreateScope();
            foreach (var dbContextType in dbContextTypes)
            {
                var dbContext = scoper.ServiceProvider.GetRequiredService(dbContextType) as DbContext;
                await dbContext.Database.MigrateAsync(cancellationToken);

            }
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
       
    }
}
