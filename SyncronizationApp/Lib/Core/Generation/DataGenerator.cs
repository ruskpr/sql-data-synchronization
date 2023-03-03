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
        public enum DeviceTypeID
        {
            Electric = 1,
            Gps = 2,
            Gas = 3,
            H2O = 4,
        }

        //public enum UOM1Type
        //{
        //    kWH = 1,
        //    Latitude = 2,
        //    CF = 3,
        //    CM= 4,
        //}

        //public enum UOM2Type
        //{
        //    kVA = 1,
        //    Longitude = 2,
        //    PSI = 3,
        //    TEMPCels = 4,
        //}

        public void GenerateData()
        {
            SqliteContext db = new SqliteContext();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                var entry = new DataEntry
                {
                    // add all fields except id...
                    DeviceName = "ELECTRIC",
                    DeviceType = new DeviceType { Id = (int)DeviceTypeID.Electric},
                    Timestamp = DateTime.Now,
                    UOM1 = new UnitOfMeasure1 { Id = (int)DeviceTypeID.Electric },
                    UOM1Value= double.Parse(rnd.Next(0, 100) + "." + rnd.Next(0, 100000000)),
                    UOM2 = new UnitOfMeasure2 { Id = (int)DeviceTypeID.Electric },
                    UOM2Value = double.Parse(rnd.Next(0, 10) + "." + rnd.Next(0, 100000000)),
                };
                for (int j = 0; j < 4; j++)
                {
                    var entry2 = new DataEntry
                    {
                        // add all fields except id...
                        DeviceName = "GPS",
                        DeviceType = new DeviceType { Id = j },
                        Timestamp = DateTime.Now,
                        UOM1 = new UnitOfMeasure1 { Id = j },
                        UOM1Value = double.Parse(rnd.Next(49, 52) + "." + rnd.Next(0, 100000000)),
                        UOM2 = new UnitOfMeasure2 { Id = j },
                        UOM2Value = double.Parse(rnd.Next(-111, -109) + "." + rnd.Next(0, 100000000)),
                    }; 
                }
                    

            }

            db.SaveChanges();
        }
    }
}
