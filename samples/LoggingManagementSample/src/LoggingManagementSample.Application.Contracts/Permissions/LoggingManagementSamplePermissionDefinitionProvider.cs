using LoggingManagementSample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LoggingManagementSample.Permissions
{
    public class LoggingManagementSamplePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LoggingManagementSamplePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LoggingManagementSamplePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoggingManagementSampleResource>(name);
        }
    }
}
