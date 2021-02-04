using System.Threading.Tasks;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using Microsoft.AspNetCore.Components;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.LoggingManagement.SystemLogs
{
    [RemoteService(Name = "EasyAbpLoggingManagement")]
    [Route("/api/logging-management/system-log")]
    public class SystemLogController : LoggingManagementController, ISystemLogAppService
    {
        private readonly ISystemLogAppService _service;

        public SystemLogController(ISystemLogAppService service)
        {
            _service = service;
        }
        
        public Task<PagedResultDto<SystemLogDto>> GetListAsync(GetSystemLogListInput input)
        {
            return _service.GetListAsync(input);
        }
    }
}