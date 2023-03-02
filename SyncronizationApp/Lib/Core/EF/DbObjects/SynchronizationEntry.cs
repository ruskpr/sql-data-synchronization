namespace Lib.Core.EF.DbObjects
{
    public class SynchronizationEntry
    {
        public int Id { get; set; }
        public int RecordsAdded { get; set; }
        public DateTime TimeSynced { get; set; }
    }
}
