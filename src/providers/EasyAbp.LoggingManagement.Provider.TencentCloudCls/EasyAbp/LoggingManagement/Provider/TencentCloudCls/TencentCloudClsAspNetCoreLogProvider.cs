using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyAbp.Abp.TencentCloud.Cls;
using EasyAbp.Abp.TencentCloud.Cls.LogManagement.SearchLog;
using EasyAbp.Abp.TencentCloud.Common;
using EasyAbp.Abp.TencentCloud.Common.Requester;
using EasyAbp.LoggingManagement.Provider.TencentCloudCls.Settings;
using EasyAbp.LoggingManagement.SystemLogs;
using EasyAbp.LoggingManagement.SystemLogs.Dtos;
using JetBrains.Annotations;
using Microsoft.Extensions.Options;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Settings;

namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls
{
    public class TencentCloudClsAspNetCoreLogProvider : IAspNetCoreLogProvider
    {
        private const int Limit = 100;
        
        private readonly ISettingProvider _settingProvider;
        private readonly ITencentCloudApiRequester _tencentCloudApiRequester;
        private readonly ISearchLogResponseConverter _searchLogResponseConverter;

        public TencentCloudClsAspNetCoreLogProvider(
            ISettingProvider settingProvider,
            ITencentCloudApiRequester tencentCloudApiRequester,
            ISearchLogResponseConverter searchLogResponseConverter)
        {
            _settingProvider = settingProvider;
            _tencentCloudApiRequester = tencentCloudApiRequester;
            _searchLogResponseConverter = searchLogResponseConverter;
        }
        
        public virtual async Task<PagedResultDto<SystemLogDto>> GetListAsync(string queryString, DateTime startTime,
            DateTime endTime, int maxResultCount, int skipCount)
        {
            var secretId = await _settingProvider.GetOrNullAsync(LoggingManagementTencentCloudClsSettings.SecretId);
            var secretKey = await _settingProvider.GetOrNullAsync(LoggingManagementTencentCloudClsSettings.SecretKey);
            var logSetId = await _settingProvider.GetOrNullAsync(LoggingManagementTencentCloudClsSettings.LogSetId);
            var topicId = await _settingProvider.GetOrNullAsync(LoggingManagementTencentCloudClsSettings.TopicId);
            var region = await _settingProvider.GetOrNullAsync(LoggingManagementTencentCloudClsSettings.Region);
            var isIntranet = await _settingProvider.IsTrueAsync(LoggingManagementTencentCloudClsSettings.IsIntranet);

            var endpoint = GetEndPoint(region, isIntranet);
            var commonOptions = new AbpTencentCloudCommonOptions
            {
                SecretId = secretId,
                SecretKey = secretKey
            };

            var dtos = await InternalGetListAsync(logSetId, topicId, startTime, endTime, queryString, endpoint,
                commonOptions, maxResultCount, skipCount);
            
            return new PagedResultDto<SystemLogDto>(dtos.Count, dtos);
        }

        protected virtual async Task<List<SystemLogDto>> InternalGetListAsync(string logSetId, string topicId, DateTime startTime,
            DateTime endTime, string queryString, string endpoint, AbpTencentCloudCommonOptions options,
            int maxResultCount, int skipCount)
        {
            var possibleCount = 0;
            var dtos = new List<SystemLogDto>();
            SearchLogResponse response;

            do
            {
                response = await _tencentCloudApiRequester.SendRequestAsync<SearchLogResponse>(
                    new SearchLogRequest(logSetId, topicId, startTime, endTime, queryString, Limit),
                    endpoint, options);

                dtos.AddRange(_searchLogResponseConverter.ToSystemLogDtoList(response));

                possibleCount += Limit;

            } while (response != null && !response.Listover && response.Results.Count > 0 &&
                     dtos.Count < maxResultCount + skipCount && possibleCount < 10000);

            return dtos.Skip(skipCount).Take(maxResultCount).ToList();
        }

        protected virtual string GetEndPoint([NotNull] string region, bool isIntranet)
        {
            return isIntranet ? $"{region}.cls.tencentyun.com" : $"{region}.cls.tencentcs.com";
        }
    }
}