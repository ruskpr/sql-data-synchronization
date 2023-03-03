using Lib.Core.EF.DbContexts;
using Lib.Core.EF.DbObjects;
using System;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Core.Synchronization
{
    public class Sync
    {
        private static bool _isSyncing;

        public static bool IsSynced()
        {
            // compare sqlite and sqlserver to see if they are syncronized
            SqliteContext sqlite = new SqliteContext();
            SqlServerContext sqlServer = new SqlServerContext();

            List<DataEntry> sqliteRecords = sqlite.DataEntries.ToList();
            List<DataEntry> sqlServerRecords = sqlServer.DataEntries.ToList();

            //1. loop through both tables to see if are the same
            // if they are, return true, else false
            for (int i = 0; i < sqliteRecords.Count; i++)
            {
                try
                {
                    if (sqliteRecords[i].Id != sqlServerRecords[i].Id)
                    {
                        return false;
                    }
                }
                catch 
                {
                    return false;
                }
                
            }
                
            return false;
        }

        public static void SyncData()
        {
            if (_isSyncing)
            {
                return;
            }

            SqlServerContext sqlServer = new SqlServerContext();

            if (sqlServer.Database.CanConnect() == false)
            {
                WindowsNotification.Show("Failed to Synchronize.", "Can't connect to the database, make sure your database server is running");
                return;
            }

            if (IsSynced())
            {
                return;
            }
            else // if not sync, synchronize
            {
                return;
                _isSyncing = true;
                SqliteContext sqlite = new SqliteContext();

                //check if sqlserver contains record, if not add it
                List<DataEntry> offlineData = sqlite.DataEntries.ToList();

                foreach (var record in offlineData)
                {
                    if (!sqlServer.DataEntries.Contains(record)) 
                    {
                        record.Id = null;
                        sqlServer.Add(record);
                    }
                }

                int records = sqlServer.SaveChanges();
                _isSyncing = false;
                WindowsNotification.Show("Successfully syncronized!",
                                        $"{records.ToString("n")} records added to the online database.");
            }
        }
    }
}
