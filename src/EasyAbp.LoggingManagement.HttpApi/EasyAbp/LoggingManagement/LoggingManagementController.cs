using EasyAbp.LoggingManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.LoggingManagement
{
    public abstract class LoggingManagementController : AbpController
    {
        protected LoggingManagementController()
        {
            LocalizationResource = typeof(LoggingManagementResource);
        }
    }
}
