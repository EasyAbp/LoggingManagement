using System.Threading.Tasks;

namespace LoggingManagementSample.Data
{
    public interface ILoggingManagementSampleDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
