using EasyAbp.LoggingManagement.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.LoggingManagement
{
    [Area(LoggingManagementRemoteServiceConsts.ModuleName)]
    public abstract class LoggingManagementController : AbpControllerBase
    {
        protected LoggingManagementController()
        {
            LocalizationResource = typeof(LoggingManagementResource);
        }
    }
}
