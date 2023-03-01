using Lib.Core;
using Microsoft.Identity.Client;
using System.Configuration;
using System.Diagnostics;

namespace SQL_syncing_service 
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            WindowsNotification.Show(NotificationType.ServiceStarted);
            bool running = true;
            int delay = AppConfig.SyncIntervalInMilliseconds;
            while (running)
            {
                // [method to sync data goes here] ex. SyncData()
                Thread.Sleep(delay);
            }

            WindowsNotification.Show(NotificationType.ServiceStopped);
        }
    }
}
