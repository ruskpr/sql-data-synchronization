using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.DbObjects
{
    public class SynchronizationEntry
    {
        public int Id { get; set; }
        public int RecordsAdded { get; set; }
        public DateTime TimeSynced { get; set; }
    }
}
