using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EasyAbp.LoggingManagement
{
    [DependsOn(
        typeof(LoggingManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LoggingManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
