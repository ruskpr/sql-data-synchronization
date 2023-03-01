namespace Lib.DbObjects
{
    public class DataEntry
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public DeviceType DeviceType { get; set; }
        public DateTime Timestamp { get; set; }
        public UnitOfMeasure1 UOM1 { get; set; }
        public double UOM1Value { get; set; }
        public UnitOfMeasure2 UOM2 { get; set; }
        public double UOM2Value { get; set; }

    }
}
