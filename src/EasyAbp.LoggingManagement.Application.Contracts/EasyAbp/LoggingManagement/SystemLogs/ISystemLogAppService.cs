using System.Threading.Tasks;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.LoggingManagement.SystemLogs
{
    public interface ISystemLogAppService : IApplicationService
    {
        Task<PagedResultDto<SystemLogDto>> GetListAsync(GetSystemLogListInput input);
    }
}