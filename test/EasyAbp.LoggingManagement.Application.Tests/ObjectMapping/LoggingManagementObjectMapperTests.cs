using Shouldly;
using Volo.Abp.ObjectMapping;
using Xunit;

namespace EasyAbp.LoggingManagement.ObjectMapping
{
    /* Verifies the application module (migrated from AutoMapper to Mapperly)
     * boots and exposes a working object mapper. */
    public class LoggingManagementObjectMapperTests : LoggingManagementApplicationTestBase
    {
        private readonly IObjectMapper _objectMapper;

        public LoggingManagementObjectMapperTests()
        {
            _objectMapper = GetRequiredService<IObjectMapper>();
        }

        [Fact]
        public void Should_Resolve_ObjectMapper()
        {
            _objectMapper.ShouldNotBeNull();
        }
    }
}
