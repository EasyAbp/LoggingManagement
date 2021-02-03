using EasyAbp.LoggingManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EasyAbp.LoggingManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(LoggingManagementEntityFrameworkCoreTestModule)
        )]
    public class LoggingManagementDomainTestModule : AbpModule
    {
        
    }
}
