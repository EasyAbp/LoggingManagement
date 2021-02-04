namespace EasyAbp.LoggingManagement.Provider.TencentCloudCls
{
    public class LoggingManagementTencentCloudClsOptions
    {
        public string SecretId { get; set; }
        
        public string SecretKey { get; set; }
        
        public string LogSetId { get; set; }
        
        public string TopicId { get; set; }
        
        public string Region { get; set; }

        public bool? IsIntranet { get; set; }
    }
}