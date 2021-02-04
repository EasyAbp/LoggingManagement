using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LoggingManagementSample.Data;
using Volo.Abp.DependencyInjection;

namespace LoggingManagementSample.EntityFrameworkCore
{
    public class EntityFrameworkCoreLoggingManagementSampleDbSchemaMigrator
        : ILoggingManagementSampleDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLoggingManagementSampleDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LoggingManagementSampleMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LoggingManagementSampleMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}