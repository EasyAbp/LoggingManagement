using LoggingManagementSample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LoggingManagementSample.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LoggingManagementSampleEntityFrameworkCoreModule),
        typeof(LoggingManagementSampleApplicationContractsModule)
        )]
    public class LoggingManagementSampleDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
