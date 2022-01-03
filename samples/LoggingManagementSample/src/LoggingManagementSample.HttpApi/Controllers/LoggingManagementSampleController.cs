using LoggingManagementSample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LoggingManagementSample.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LoggingManagementSampleController : AbpControllerBase
    {
        protected LoggingManagementSampleController()
        {
            LocalizationResource = typeof(LoggingManagementSampleResource);
        }
    }
}