using System;
using System.Linq;
using System.Threading.Tasks;
using EasyAbp.LoggingManagement.Provider.TencentCloudCls;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace EasyAbp.LoggingManagement
{
    public class TencentCloudClsAspNetCoreLogProviderTest : LoggingManagementProviderTencentCloudClsTestBase
    {
        [Fact]
        public async Task Should_Get_Logs_From_1_To_10()
        {
            var provider = ServiceProvider.GetRequiredService<TencentCloudClsAspNetCoreLogProvider>();

            var logs = await provider.GetListAsync("", DateTime.MinValue, DateTime.Now, 10, 0);
            
            logs.TotalCount.ShouldNotBe(0);
            logs.Items.ShouldNotBeEmpty();
            logs.Items[0].Time.ShouldNotBeNull();
            logs.Items[0].LogValue.ShouldNotBeNullOrWhiteSpace();
        }
        
        [Fact]
        public async Task Should_Get_Logs_From_1_To_101()
        {
            var provider = ServiceProvider.GetRequiredService<TencentCloudClsAspNetCoreLogProvider>();

            var logs = await provider.GetListAsync("", DateTime.MinValue, DateTime.Now, 101, 0);
            
            logs.TotalCount.ShouldBe(101);
            logs.Items.ShouldNotBeEmpty();
        }
        
        [Fact]
        public async Task Should_Get_Logs_From_11_To_101()
        {
            var provider = ServiceProvider.GetRequiredService<TencentCloudClsAspNetCoreLogProvider>();

            var logs = await provider.GetListAsync("", DateTime.MinValue, DateTime.Now, 101, 10);
            
            logs.TotalCount.ShouldBe(101);
            logs.Items.ShouldNotBeEmpty();
        }
    }
}