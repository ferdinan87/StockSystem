using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorBinDip
    {
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public string Bin { get; set; } = null!;
        public DateTime DipTime { get; set; }
        public double? DipValue { get; set; }
        public double? Tonnes { get; set; }

        public virtual TopFloorRoot ShiftDateNavigation { get; set; } = null!;
    }
}
