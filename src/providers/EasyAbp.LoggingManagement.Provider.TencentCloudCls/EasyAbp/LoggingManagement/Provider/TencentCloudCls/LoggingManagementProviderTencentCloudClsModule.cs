using EasyAbp.Abp.TencentCloud.Cls;
using EasyAbp.LoggingManagement.SystemLogs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls
{
    [DependsOn(
        typeof(LoggingManagementApplicationModule),
        typeof(AbpTencentCloudClsModule)
    )]
    public class LoggingManagementProviderTencentCloudClsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<TencentCloudClsAspNetCoreLogProvider>();
            context.Services.AddTransient<IAspNetCoreLogProvider, TencentCloudClsAspNetCoreLogProvider>();
        }
    }
}
