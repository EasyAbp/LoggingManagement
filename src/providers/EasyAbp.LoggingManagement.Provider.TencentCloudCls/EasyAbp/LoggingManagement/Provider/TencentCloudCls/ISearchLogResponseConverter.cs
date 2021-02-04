using System.Collections.Generic;
using EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;

namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls
{
    public interface ISearchLogResponseConverter
    {
        List<SystemLogDto> ToSystemLogDtoList(SearchLogResponse response);
    }
}