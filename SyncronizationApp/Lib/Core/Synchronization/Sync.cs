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
            // see if there are any records queued inside the offline db
            // if there are IsSynced is false
            // if there are no records, IsSynced is true
            SqliteContext sqlite = new SqliteContext();
            List<DataEntry> sqliteRecords = sqlite.DataEntries.ToList();

            if (sqliteRecords.Count == 0)
            {
                // no records to sync
                WindowsNotification.Show("Up to date✔", "No records to sync.");
                return true;
            }
            else 
            {
                return false;
            }
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
                
                _isSyncing = true;

                // check if sqlite db has any records
                // if it does push them to sqlserver
                SqliteContext sqlite = new SqliteContext();
                List<DataEntry> offlineRecords = sqlite.DataEntries.ToList();
                if (sqlite.DataEntries.Count() > 0)
                {
                    // convert records
                    foreach (var record in offlineRecords)
                    {
                        // copy record with id field to avoid PK conflicts
                        var convertedRecord = new DataEntry()
                        {
                            DeviceName = record.DeviceName,
                            DeviceType = record.DeviceType,
                            Timestamp = record.Timestamp,
                            UOM1 = record.UOM1,
                            UOM1Value = record.UOM1Value,
                            UOM2 = record.UOM2,
                            UOM2Value = record.UOM2Value,
                        };

                        // add all offline data to online db
                        sqlServer.Add(convertedRecord);
                    }

                    // remove all items from sqlite database
                    // to ensure that they were 
                    sqlite.RemoveRange(offlineRecords);
                }

                // add to metadata table
                var syncRecord = new SynchronizationEntry()
                {
                    RecordsAdded = offlineRecords.Count,
                    TimeSynced = DateTime.Now
                };
                sqlServer.Synchronizations.Add(syncRecord);

                // update both databases
                int recordCount = sqlServer.SaveChanges() - 1;
                sqlite.SaveChanges();
                _isSyncing = false;

                // show message
                WindowsNotification.Show("Successfully syncronized!",
                                        $"{recordCount} records added to the online database.");
            }

        }
    }
}
