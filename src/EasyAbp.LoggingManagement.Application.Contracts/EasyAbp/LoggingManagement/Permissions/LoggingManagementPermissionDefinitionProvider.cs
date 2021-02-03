using EasyAbp.LoggingManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.LoggingManagement.Permissions
{
    public class LoggingManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LoggingManagementPermissions.GroupName, L("Permission:LoggingManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoggingManagementResource>(name);
        }
    }
}