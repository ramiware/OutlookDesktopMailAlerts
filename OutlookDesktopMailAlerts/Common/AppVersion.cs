using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookDesktopMailAlerts.Common
{
    public static class AppVersion
    {
        public static string APP_ID = "Outlook Desktop Mail Alerts";
        public static string APP_VERSION = "Version 1.00";
        public static string APP_LAST_UPDATED = "2024-05-04";
        public static string APP_INFO = "Microsoft Outlook's default behavior does not include subfolder notification, but we've fixed that with Outlook Desktop Mail Alerts.\n" +
                                        "Use Outlook Desktop Mail Alerts to get notifications for new mail in your Inbox and all Sub Folders.\n\n" +
                                        "Features included in the current version:\n" +
                                        " - Popup Notifications for new mail in Inbox\n" +
                                        " - Popup Notifications for new mail in Folders\n" +
                                        " - Popup features are 'dismiss popup', 'open mail', 'delete mail', 'mark as read'\n" +
                                        " - Hide widget. Default location is the bottom right, but you can move it, or simply hide it if it gets in the way.\n" +
                                        " - Select which folders to scan and which to completely ignore (Settings)\n\n" +
                                        "Send us an email for any new feature you would like to see!\n" +
                                        "Thanks for using Outlook Desktop Mail Alerts!";
    }
}


/*********************************************************************************************************************
 * REVISION HISTORY
 * 
 * -------------------------------------------------------------------------------------------------------------
 * Date			Developer				Version Description
 * -------------------------------------------------------------------------------------------------------------
 * 2024-05-04	Rami Sorikh    			V1.00   Created application
 * 
 *********************************************************************************************************************/

// *****************************
// OPEN TASKS
// *****************************
// DONE - PopUp - hide for last tick. This will help when there are multiple popups.
// DONE - PopUp - Add childFolder as part of title (ie: Mail - "DSR")
// DONE - MainWindow - Add tooltips
// DONE - PopUp - Add function - 'close popup', 'set to read', 'delete', 'open'
// DONE - PopUp - Add tooltips
// DONE - Settings - hide widget
// DONE - Settings - Ignore folders
// - UI - update backgrounds to use gradients (canva)
// - Installation Package
// DONE - Replaced Settings-General-AssemblyName from $(MSBuildProjectName) to Outlook Desktop Mail Alerts