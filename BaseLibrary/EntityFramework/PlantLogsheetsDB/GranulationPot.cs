using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class GranulationPot
    {
        public string BlowId { get; set; } = null!;
        public int PotNumber { get; set; }
        public DateTime TimeOut { get; set; }
        public double Mass { get; set; }

        public virtual GranulationSummary Blow { get; set; } = null!;
    }
}
