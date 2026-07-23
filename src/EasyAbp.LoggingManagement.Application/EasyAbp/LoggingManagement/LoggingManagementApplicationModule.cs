using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace EasyAbp.LoggingManagement
{
    [DependsOn(
        typeof(LoggingManagementApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpMapperlyModule)
        )]
    public class LoggingManagementApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMapperlyObjectMapper<LoggingManagementApplicationModule>();
        }
    }
}
