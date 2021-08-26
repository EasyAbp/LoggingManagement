using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LoggingManagementSample.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LoggingManagementSampleDbContextFactory : IDesignTimeDbContextFactory<LoggingManagementSampleDbContext>
    {
        public LoggingManagementSampleDbContext CreateDbContext(string[] args)
        {
            LoggingManagementSampleEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LoggingManagementSampleDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LoggingManagementSampleDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LoggingManagementSample.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
