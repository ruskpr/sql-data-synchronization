using Lib.Core;

namespace SQL_syncing_service
{
    class Program
    {
        
        public static void Main()
        {
            WindowsNotification.Show(NotiType.ServiceStarted);
            bool _running = true;
            int delay = AppConfig.SyncIntervalInMilliseconds;
            while (_running)
            {
                // [method to sync data goes here] ex. SyncData()
                Thread.Sleep(delay);
                WindowsNotification.Show(NotiType.SyncSuccess);
            }

        }
    }
}
