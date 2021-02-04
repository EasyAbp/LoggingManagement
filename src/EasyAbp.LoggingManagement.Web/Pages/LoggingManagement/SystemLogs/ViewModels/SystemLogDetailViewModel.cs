using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs.ViewModels
{
    public class SystemLogDetailViewModel
    {
        [DisabledInput]
        public string LogName { get; set; }
        
        [DisabledInput]
        [TextArea(Rows = 5)]
        public string LogValue { get; set; }
        
        [DisabledInput]
        public DateTime? Time { get; set; }
    }
}