using Lib.Core.EF.DbContexts;
using Lib.Core.EF.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Core.Synchronization
{
    public class Sync
    {
        public static bool IsSynced()
        {
            bool isSynced = false;
            // compare sqlite and sqlserver to see if they are syncronized
            SqliteContext sqlite = new SqliteContext();
            SqlServerContext sqlServer = new SqlServerContext();

            List<DataEntry> sqliteRecords = sqlite.DataEntries.ToList();
            List<DataEntry> sqlServerRecords = sqlServer.DataEntries.ToList();

            //1. loop
            return isSynced;
        }


        public static void SyncData()
        {

        }
    }
}
