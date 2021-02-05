using System;
using System.ComponentModel.DataAnnotations;

namespace EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs.ViewModels
{
    public class SystemLogsQueryViewModel
    {
        [Display(Name = "SystemLogQueryString")]
        public string QueryString { get; set; }
        
        [Display(Name = "SystemLogStartTime")]
        public DateTime StartTime { get; set; } = DateTime.Now.Date;
        
        [Display(Name = "SystemLogEndTime")]
        public DateTime EndTime { get; set; } = DateTime.Now;
    }
}