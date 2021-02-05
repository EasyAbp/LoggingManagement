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
    }
}