using System;
using System.Threading.Tasks;
using EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EasyAbp.LoggingManagement.Web.Pages.LoggingManagement.SystemLogs
{
    public class IndexModel : LoggingManagementPageModel
    {
        [BindProperty(SupportsGet = true)]
        public SystemLogsQueryViewModel QueryModel { get; set; } 

        public async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
