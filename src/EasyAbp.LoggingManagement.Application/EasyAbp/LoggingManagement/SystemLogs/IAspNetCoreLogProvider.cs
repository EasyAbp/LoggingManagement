using System;
using System.Threading.Tasks;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using JetBrains.Annotations;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.LoggingManagement.SystemLogs
{
    public interface IAspNetCoreLogProvider
    {
        Task<PagedResultDto<SystemLogDto>> GetListAsync([CanBeNull] string queryString, DateTime startTime,
            DateTime endTime, int maxResultCount, int skipCount);
    }
}