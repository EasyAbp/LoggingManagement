using Volo.Abp.Modularity;

namespace LoggingManagementSample
{
    [DependsOn(
        typeof(LoggingManagementSampleApplicationModule),
        typeof(LoggingManagementSampleDomainTestModule)
        )]
    public class LoggingManagementSampleApplicationTestModule : AbpModule
    {

    }
}