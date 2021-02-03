using EasyAbp.LoggingManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.LoggingManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LoggingManagementPageModel : AbpPageModel
    {
        protected LoggingManagementPageModel()
        {
            LocalizationResourceType = typeof(LoggingManagementResource);
            ObjectMapperContext = typeof(LoggingManagementWebModule);
        }
    }
}