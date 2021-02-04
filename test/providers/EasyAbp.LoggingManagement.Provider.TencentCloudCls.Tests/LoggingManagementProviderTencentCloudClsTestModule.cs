using EasyAbp.LoggingManagement.Provider.TencentCloudCls;
using Volo.Abp.Modularity;

namespace EasyAbp.LoggingManagement
{
    [DependsOn(
        typeof(LoggingManagementApplicationTestModule),
        typeof(LoggingManagementProviderTencentCloudClsModule)
    )]
    public class LoggingManagementProviderTencentCloudClsTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
