using System;
using System.Collections.Generic;
using System.Text;
using LoggingManagementSample.Localization;
using Volo.Abp.Application.Services;

namespace LoggingManagementSample
{
    /* Inherit your application services from this class.
     */
    public abstract class LoggingManagementSampleAppService : ApplicationService
    {
        protected LoggingManagementSampleAppService()
        {
            LocalizationResource = typeof(LoggingManagementSampleResource);
        }
    }
}
