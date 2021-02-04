using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace LoggingManagementSample.Web
{
    [Dependency(ReplaceServices = true)]
    public class LoggingManagementSampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "LoggingManagementSample";
    }
}
