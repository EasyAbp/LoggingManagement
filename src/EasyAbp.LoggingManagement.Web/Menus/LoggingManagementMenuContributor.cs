using System.Collections.Generic;
using System.Threading.Tasks;
using EasyAbp.LoggingManagement.Localization;
using EasyAbp.LoggingManagement.Permissions;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.LoggingManagement.Web.Menus
{
    public class LoggingManagementMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenu(context);
            }
        }

        private async Task ConfigureMainMenu(MenuConfigurationContext context)
        {
            //Add main menu items.

            var l = context.GetLocalizer<LoggingManagementResource>();

            var loggingManagementMenuItem = new ApplicationMenuItem(LoggingManagementMenus.Prefix, l["Menu:LoggingManagement"]);

            if (await context.IsGrantedAsync(LoggingManagementPermissions.SystemLog.Default))
            {
                loggingManagementMenuItem.AddItem(
                    new ApplicationMenuItem(LoggingManagementMenus.SystemLogs, l["Menu:SystemLogs"], "/LoggingManagement/SystemLogs")
                );
            }
            
            if (!loggingManagementMenuItem.Items.IsNullOrEmpty())
            {
                context.Menu.Items.Add(loggingManagementMenuItem);
            }
        }
    }
}