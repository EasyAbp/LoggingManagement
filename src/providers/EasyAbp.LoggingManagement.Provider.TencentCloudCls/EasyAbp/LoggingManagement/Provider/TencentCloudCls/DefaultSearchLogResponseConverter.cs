using System;
using System.Collections.Generic;
using System.Linq;
using EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Json;

namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls
{
    [Dependency(TryRegister = true)]
    public class DefaultSearchLogResponseConverter : ISearchLogResponseConverter, ITransientDependency
    {
        private readonly IJsonSerializer _jsonSerializer;

        public DefaultSearchLogResponseConverter(IJsonSerializer jsonSerializer)
        {
            _jsonSerializer = jsonSerializer;
        }
        
        public virtual List<SystemLogDto> ToSystemLogDtoList(SearchLogResponse response)
        {
            return response.Results.Select(x => new SystemLogDto
            {
                LogName = GetLogNameFromTencentClsLogObject(x),
                LogValue = x.Content,
                Time = x.Timestamp.IsNullOrEmpty() ? null : DateTime.Parse(x.Timestamp)
            }).ToList();
        }

        protected virtual string GetLogNameFromTencentClsLogObject(TencentClsLogObject tencentClsLogObject)
        {
            var dict = _jsonSerializer.Deserialize<Dictionary<string, string>>(tencentClsLogObject.Content);
            
            return dict.ContainsKey("MessageTemplate") ? dict["MessageTemplate"] : "unknown";
        }
    }
}