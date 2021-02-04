using System;
using JetBrains.Annotations;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.LoggingManagement.SystemLogs.Dtos
{
    public class GetSystemLogListInput : PagedResultRequestDto
    {
        [CanBeNull]
        public string QueryString { get; set; }
        
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }
    }
}