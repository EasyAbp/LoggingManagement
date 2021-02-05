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
            return response.Results.Select(CreateSystemLogDto).ToList();
        }

        protected virtual SystemLogDto CreateSystemLogDto(TencentClsLogObject obj)
        {
            var dict = _jsonSerializer.Deserialize<Dictionary<string, string>>(obj.Content);

            return new SystemLogDto
            {
                LogName = dict.ContainsKey("MessageTemplate") ? dict["MessageTemplate"] : "unknown",
                LogValue = obj.Content,
                Time = obj.Timestamp.IsNullOrEmpty() ? null : DateTime.Parse(obj.Timestamp),
                Level = dict.ContainsKey("Level") ? dict["Level"] : "unknown"
            };
        }
    }
}