using System;
using System.Threading.Tasks;
using EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs
{
    public class DetailModalModel : LoggingManagementPageModel
    {
        [BindProperty]
        public SystemLogDetailViewModel SystemLog { get; set; }

        public void OnGet(string logName, string logValue, DateTime? time)
        {
            SystemLog = new SystemLogDetailViewModel
            {
                LogName = logName,
                LogValue = logValue,
                Time = time
            };
        }
    }
}