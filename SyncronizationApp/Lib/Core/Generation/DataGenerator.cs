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

        public void GenerateData(int numRecords)
        {
            SqliteContext sqliteDb = new SqliteContext();
            Random rnd = new Random();
            for (int i = 0; i < numRecords / 4; i++)
            {
                
                for (int j = 0; j < 4; j++)
                {
                    if(j == 0)
                    {
                        var entry = new DataEntry
                        {
                            // add all fields except id...
                            DeviceName = "Elec",
                            DeviceType = "Electric",
                            Timestamp = DateTime.Now,
                            UOM1 = "kWH",
                            UOM1Value = double.Parse(rnd.Next(0, 100) + "." + rnd.Next(0, 100000000)),
                            UOM2 = "kVA",
                            UOM2Value = double.Parse(rnd.Next(0, 10) + "." + rnd.Next(0, 100000000)),
                        };
                        sqliteDb.Add(entry);
                    }
                    else if (j == 1)
                    {
                        var entry = new DataEntry
                        {
                            // add all fields except id...
                            DeviceName = "GEO",
                            DeviceType = "GPS",
                            Timestamp = DateTime.Now,
                            UOM1 = "Latitude",
                            UOM1Value = double.Parse(rnd.Next(49, 52) + "." + rnd.Next(0, 100000000)),
                            UOM2 = "Longitude",
                            UOM2Value = double.Parse(rnd.Next(-111, -109) + "." + rnd.Next(0, 100000000)),
                        };
                        sqliteDb.Add(entry);
                    }
                    else if (j == 2)
                    {
                        var entry = new DataEntry
                        {
                            // add all fields except id...
                            DeviceName = "GMetero",
                            DeviceType = "GAS",
                            Timestamp = DateTime.Now,
                            UOM1 = "CF",
                            UOM1Value = double.Parse(rnd.Next(0, 1000) + "." + rnd.Next(0, 100000000)),
                            UOM2 = "PSI",
                            UOM2Value = double.Parse(rnd.Next(0, 2) + "." + rnd.Next(0, 100000000)),
                        };
                        sqliteDb.Add(entry);
                    }
                    else if (j == 3)
                    {
                        var entry = new DataEntry
                        {
                            // add all fields except id...
                            DeviceName = "H20Meter",
                            DeviceType = "H20",
                            Timestamp = DateTime.Now,
                            UOM1 = "CM",
                            UOM1Value = double.Parse(rnd.Next(0, 100) + "." + rnd.Next(0, 100000000)),
                            UOM2 = "Celsius",
                            UOM2Value = double.Parse(rnd.Next(-3, 30) + "." + rnd.Next(0, 100000000)),
                        };
                        sqliteDb.Add(entry);
                    }

                }
            }

            sqliteDb.SaveChanges();
        }
    }
}
