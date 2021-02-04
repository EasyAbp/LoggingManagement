using LoggingManagementSample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LoggingManagementSample
{
    [DependsOn(
        typeof(LoggingManagementSampleEntityFrameworkCoreTestModule)
        )]
    public class LoggingManagementSampleDomainTestModule : AbpModule
    {

    }
}