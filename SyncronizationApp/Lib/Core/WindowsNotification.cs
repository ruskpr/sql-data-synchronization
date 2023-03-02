using Microsoft.Toolkit.Uwp.Notifications;

namespace Lib.Core
{
    public enum NotiType { ServiceStarted, ServiceStopped, SyncSuccess, SyncFailed }

    public static class WindowsNotification
    {
        
        public static void Show(NotiType notificationType)
        {
            switch (notificationType)
            {
                case NotiType.ServiceStarted:

                    new ToastContentBuilder()
                        .AddText("Syncronization service has started!")
                        .AddText("You data will automatically synchronize to your targeted database while this service is running.")
                        .AddText("\nYou can set you target database by editing the App.config file.")
                        .Show();

                    break;
                case NotiType.ServiceStopped:
                    new ToastContentBuilder()
                        .AddText("Alert!")
                        .AddText("Syncronization service has stopped running.")
                        .Show();
                    break;
                case NotiType.SyncSuccess:
                    new ToastContentBuilder()
                        .AddText("Successfully Synchronized!")
                        .AddText("Syncronization service has successfully updated you database.")
                        .Show();
                    break;
                case NotiType.SyncFailed:
                    new ToastContentBuilder()
                        .AddText("Failed to Synchronize")
                        .AddText("Syncronization service could not connect to your database.")
                        .Show();
                    break;
                default:
                    break;
            }

        }

        public static void Show(string title, string description)
        {
            new ToastContentBuilder()
                        .AddText(title)
                        .AddText(description)
                        .Show();
        }
    }
}
