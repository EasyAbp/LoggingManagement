namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls.Settings
{
    public static class LoggingManagementTencentCloudClsSettings
    {
        public const string GroupName = "EasyAbp.LoggingManagement.Provider.TencentCloudCls";

        /* Add constants for setting names. Example:
         * public const string MySettingName = GroupName + ".MySettingName";
         */
        
        public const string SecretId = GroupName + ".SecretId";
        public const string SecretKey = GroupName + ".SecretKey";
        public const string LogSetId = GroupName + ".LogSetId";
        public const string TopicId = GroupName + ".TopicId";
        public const string Region = GroupName + ".Region";
        public const string IsIntranet = GroupName + ".IsIntranet";
    }
}