using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LoggingManagementSample.Data
{
    /* This is used if database provider does't define
     * ILoggingManagementSampleDbSchemaMigrator implementation.
     */
    public class NullLoggingManagementSampleDbSchemaMigrator : ILoggingManagementSampleDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}