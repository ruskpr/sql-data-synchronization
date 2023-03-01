using Microsoft.Toolkit.Uwp.Notifications;

namespace Lib.Core
{
    public enum NotificationType { ServiceStarted, ServiceStopped, SyncSuccess, SyncFailed }

    public static class WindowsNotification
    {
        
        public static void Show(NotificationType notificationType)
        {
            switch (notificationType)
            {
                case NotificationType.ServiceStarted:

                    new ToastContentBuilder()
                        .AddText("Syncronization service has started!")
                        .AddText("You data will automatically synchronize to your targeted database while this service is running.")
                        .AddText("\nYou can set you target database by editing the App.config file.")
                        .Show();

                    break;
                case NotificationType.ServiceStopped:
                    new ToastContentBuilder()
                        .AddText("Alert!")
                        .AddText("Syncronization service has stopped running.")
                        .Show();
                    break;
                case NotificationType.SyncSuccess:
                    break;
                case NotificationType.SyncFailed:
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
