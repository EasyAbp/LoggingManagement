using System;

namespace EasyAbp.LoggingManagement.SystemLogs.Dtos
{
    public class SystemLogDto
    {
        public string LogName { get; set; }
        
        public string LogValue { get; set; }
        
        public DateTime? Time { get; set; }
        
        public string Level { get; set; }
    }
}