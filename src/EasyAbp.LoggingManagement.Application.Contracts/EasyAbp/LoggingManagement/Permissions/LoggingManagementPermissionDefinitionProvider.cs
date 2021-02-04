using EasyAbp.LoggingManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.LoggingManagement.Permissions
{
    public class LoggingManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LoggingManagementPermissions.GroupName, L("Permission:LoggingManagement"));

            var systemLog = myGroup.AddPermission(LoggingManagementPermissions.SystemLog.Default,
                L("Permission:SystemLog"), MultiTenancySides.Host);
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoggingManagementResource>(name);
        }
    }
}