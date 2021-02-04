using System;
using EasyAbp.Abp.TencentCloud.Cls;
using EasyAbp.Abp.TencentCloud.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Volo.Abp.Settings;

namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls.Settings
{
    public class LoggingManagementTencentCloudClsSettingDefinitionProvider : SettingDefinitionProvider
    {
        private readonly AbpTencentCloudCommonOptions _commonOptions;
        private readonly AbpTencentCloudClsOptions _clsOptions;
        private readonly LoggingManagementTencentCloudClsOptions _options;

        public LoggingManagementTencentCloudClsSettingDefinitionProvider(
            IOptions<AbpTencentCloudCommonOptions> commonOptions,
            IOptions<AbpTencentCloudClsOptions> clsOptions,
            IOptions<LoggingManagementTencentCloudClsOptions> options)
        {
            _commonOptions = commonOptions.Value;
            _clsOptions = clsOptions.Value;
            _options = options.Value;
        }
        
        public override void Define(ISettingDefinitionContext context)
        {
            /* Define module settings here.
             * Use names from WeChatPaySettings class.
             */
            
            context.Add(
                new SettingDefinition(LoggingManagementTencentCloudClsSettings.SecretId, _options.SecretId ?? _commonOptions.SecretId),
                new SettingDefinition(LoggingManagementTencentCloudClsSettings.SecretKey, _options.SecretKey ?? _commonOptions.SecretKey),
                new SettingDefinition(LoggingManagementTencentCloudClsSettings.LogSetId, _options.LogSetId),
                new SettingDefinition(LoggingManagementTencentCloudClsSettings.TopicId, _options.TopicId),
                new SettingDefinition(LoggingManagementTencentCloudClsSettings.Region, _options.Region ?? _clsOptions.Region),
                new SettingDefinition(LoggingManagementTencentCloudClsSettings.IsIntranet, _options.IsIntranet?.ToString() ?? _clsOptions.IsIntranet.ToString())
            );
        }
    }
}