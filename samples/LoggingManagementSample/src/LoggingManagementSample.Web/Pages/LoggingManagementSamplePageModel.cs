using LoggingManagementSample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LoggingManagementSample.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LoggingManagementSamplePageModel : AbpPageModel
    {
        protected LoggingManagementSamplePageModel()
        {
            LocalizationResourceType = typeof(LoggingManagementSampleResource);
        }
    }
}