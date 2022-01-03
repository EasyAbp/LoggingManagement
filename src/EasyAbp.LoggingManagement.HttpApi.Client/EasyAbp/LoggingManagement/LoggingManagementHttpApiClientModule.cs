using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.LoggingManagement
{
    [DependsOn(
        typeof(LoggingManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class LoggingManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = LoggingManagementRemoteServiceConsts.RemoteServiceName;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(LoggingManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LoggingManagementHttpApiClientModule>();
            });
        }
    }
}
