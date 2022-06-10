using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSupervisorDayEndTarget
    {
        public FurnaceSupervisorDayEndTarget()
        {
            FurnaceSupervisorDayEndEntries = new HashSet<FurnaceSupervisorDayEndEntry>();
        }

        public string ItemName { get; set; } = null!;
        public double? Target { get; set; }

        public virtual ICollection<FurnaceSupervisorDayEndEntry> FurnaceSupervisorDayEndEntries { get; set; }
    }
}
