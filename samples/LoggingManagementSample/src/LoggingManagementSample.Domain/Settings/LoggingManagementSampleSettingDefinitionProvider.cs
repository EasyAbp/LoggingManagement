using Volo.Abp.Settings;

namespace LoggingManagementSample.Settings
{
    public class LoggingManagementSampleSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(LoggingManagementSampleSettings.MySetting1));
        }
    }
}
