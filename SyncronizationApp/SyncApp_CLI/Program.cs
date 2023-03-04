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
                Lib.Core.Synchronization.Sync.SyncData();
                Thread.Sleep(delay); // wait x amount of seconds 
            }

        }
    }
}
