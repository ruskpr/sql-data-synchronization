namespace Lib.Core.EF.DbObjects
{
    public class DataEntry
    {
        public int? Id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public DateTime Timestamp { get; set; }
        public string UOM1 { get; set; }
        public double UOM1Value { get; set; }
        public string UOM2 { get; set; }
        public double UOM2Value { get; set; }

    }
}
