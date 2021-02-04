using System;
using System.Threading.Tasks;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.LoggingManagement.SystemLogs
{
    [Dependency(TryRegister = true)]
    public class NullAspNetCoreLogProvider : IAspNetCoreLogProvider, ITransientDependency
    {
        public virtual Task<PagedResultDto<SystemLogDto>> GetListAsync(string queryString, DateTime startTime,
            DateTime endTime, int maxResultCount, int skipCount)
        {
            throw new NotImplementedException();
        }
    }
}