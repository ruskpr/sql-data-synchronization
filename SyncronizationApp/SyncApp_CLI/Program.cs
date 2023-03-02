using Lib.Core;
using Microsoft.Identity.Client;
using System.Configuration;
using System.Diagnostics;

namespace SQL_syncing_service 
{
    class Program
    {
        
        public static void Main()
        {
            WindowsNotification.Show(NotiType.ServiceStarted);
            bool running = true;
            int delay = AppConfig.SyncIntervalInMilliseconds;
            while (running)
            {
                // [method to sync data goes here] ex. SyncData()
                Thread.Sleep(delay);
                WindowsNotification.Show(NotiType.SyncSuccess);
            }

            WindowsNotification.Show(NotiType.ServiceStopped);
        }
    }
}
