using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_syncing_service
{
    public static class AppConfig
    {
        #region public static props

        public static int SyncIntervalInMilliseconds
        {
            get => SyncIntervalInSeconds * 1000;
        }

        public static int SyncIntervalInSeconds
        {
            get
            {
                string rawStringValue = ConfigurationManager.AppSettings.Get("SyncIntervalInSeconds") ?? 
                    throw new Exception("Could not find 'SyncIntervalInSeconds' in App.config file");

                return Convert.ToInt32(rawStringValue);
            }
        }

        #endregion
    }
}
