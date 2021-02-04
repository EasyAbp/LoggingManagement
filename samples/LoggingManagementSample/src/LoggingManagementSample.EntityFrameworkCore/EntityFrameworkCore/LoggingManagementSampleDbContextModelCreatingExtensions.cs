using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LoggingManagementSample.EntityFrameworkCore
{
    public static class LoggingManagementSampleDbContextModelCreatingExtensions
    {
        public static void ConfigureLoggingManagementSample(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LoggingManagementSampleConsts.DbTablePrefix + "YourEntities", LoggingManagementSampleConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}