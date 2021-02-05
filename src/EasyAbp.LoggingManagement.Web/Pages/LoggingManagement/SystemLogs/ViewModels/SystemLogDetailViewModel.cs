using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs.ViewModels
{
    public class SystemLogDetailViewModel
    {
        [DisabledInput]
        [Display(Name = "SystemLogLevel")]
        public string Level { get; set; }

        [DisabledInput]
        [Display(Name = "SystemLogLogName")]
        public string LogName { get; set; }
        
        [DisabledInput]
        [Display(Name = "SystemLogLogValue")]
        [TextArea(Rows = 12)]
        public string LogValue { get; set; }
        
        [DisabledInput]
        [Display(Name = "SystemLogTime")]
        public DateTime? Time { get; set; }
    }
}