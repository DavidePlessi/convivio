using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Convivio.API.Services
{
    public class Repository : DbContext
    {
        //TODO: move to config.json
        private const string ConnectionString ="Data Source=localhost;" +
                                               "Initial Catalog=Convivio;" +
                                               "Persist Security Info=True;" +
                                               "User ID=SA;Password=Password1!";

        private static ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                builder
                    .AddDebug()
                    .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information));
            return serviceCollection.BuildServiceProvider().GetService<ILoggerFactory>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(GetLoggerFactory())
                .UseSqlServer(ConnectionString);
        }
    }
}