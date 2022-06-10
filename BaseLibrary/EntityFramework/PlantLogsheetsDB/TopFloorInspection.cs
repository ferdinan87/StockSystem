using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorInspection
    {
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public string CheckType { get; set; } = null!;
        public bool? ConditionOk { get; set; }
        public string? Comment { get; set; }

        public virtual TopFloorRoot ShiftDateNavigation { get; set; } = null!;
    }
}
