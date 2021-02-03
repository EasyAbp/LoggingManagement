using Volo.Abp.Modularity;

namespace EasyAbp.LoggingManagement
{
    [DependsOn(
        typeof(LoggingManagementApplicationModule),
        typeof(LoggingManagementTestBaseModule)
    )]
    public class LoggingManagementApplicationTestModule : AbpModule
    {

    }
}
