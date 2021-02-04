using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LoggingManagementSample.EntityFrameworkCore
{
    [DependsOn(
        typeof(LoggingManagementSampleEntityFrameworkCoreModule)
        )]
    public class LoggingManagementSampleEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LoggingManagementSampleMigrationsDbContext>();
        }
    }
}
