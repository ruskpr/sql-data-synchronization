using Lib.Core.EF.DbContexts;
using Lib.Core.EF.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Core.Generation
{
    public class DataGenerator
    {
        public enum DeviceType
        {
            Electric = 1,
            Gps = 2,
            Gas = 3,
            H2O = 4,
        }

        public enum UOM1Type
        {
            kWH = 1,
            Latitude = 2,
            CF = 3,
            CM= 4,
        }

        public enum UOM2Type
        {
            kVA = 1,
            Longitude = 2,
            PSI = 3,
            TEMPCels = 4,
        }

        public void GenerateData(string path)
        {
            SqliteContext db = new SqliteContext();

            for (int i = 0; i < 10000; i++)
            {
                var entry = new DataEntry
                {
                    // add all fields except id...
                    DeviceName = "random"
                };

            }

            db.SaveChanges();
        }
    }
}
