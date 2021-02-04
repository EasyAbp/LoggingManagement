using Volo.Abp.Reflection;

namespace EasyAbp.LoggingManagement.Permissions
{
    public class LoggingManagementPermissions
    {
        public const string GroupName = "EasyAbp.LoggingManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(LoggingManagementPermissions));
        }
        
        public class SystemLog
        {
            public const string Default = GroupName + ".SystemLogging";
        }
    }
}