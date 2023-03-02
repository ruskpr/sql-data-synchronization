using Lib.Core;

namespace SQL_syncing_service
{
    class Program
    {
        
        public static void Main()
        {
            WindowsNotification.Show(NotiType.ServiceStarted);
            int delay = AppConfig.SyncIntervalInMilliseconds;
            while (true)
            {
                // [method to sync data goes here] ex. SyncData()
                Thread.Sleep(delay);
                WindowsNotification.Show(NotiType.SyncSuccess);
            }

        }
    }
}
