using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace EasyAbp.LoggingManagement
{
    [DependsOn(
        typeof(LoggingManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class LoggingManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "EasyAbpLoggingManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(LoggingManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
