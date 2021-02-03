using EasyAbp.LoggingManagement.Localization;
using Volo.Abp.Application.Services;

namespace EasyAbp.LoggingManagement
{
    public abstract class LoggingManagementAppService : ApplicationService
    {
        protected LoggingManagementAppService()
        {
            LocalizationResource = typeof(LoggingManagementResource);
            ObjectMapperContext = typeof(LoggingManagementApplicationModule);
        }
    }
}
