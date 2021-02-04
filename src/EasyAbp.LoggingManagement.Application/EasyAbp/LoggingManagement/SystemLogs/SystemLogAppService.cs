using System.Threading.Tasks;
using EasyAbp.LoggingManagement.Permissions;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.LoggingManagement.SystemLogs
{
    [Authorize(LoggingManagementPermissions.SystemLog.Default)]
    public class SystemLogAppService : ApplicationService, ISystemLogAppService
    {
        private readonly IAspNetCoreLogProvider _aspNetCoreLogProvider;

        public SystemLogAppService(IAspNetCoreLogProvider aspNetCoreLogProvider)
        {
            _aspNetCoreLogProvider = aspNetCoreLogProvider;
        }
        
        public virtual async Task<PagedResultDto<SystemLogDto>> GetListAsync(GetSystemLogListInput input)
        {
            return await _aspNetCoreLogProvider.GetListAsync(input.QueryString, input.StartTime, input.EndTime,
                input.MaxResultCount, input.SkipCount);
        }
    }
}