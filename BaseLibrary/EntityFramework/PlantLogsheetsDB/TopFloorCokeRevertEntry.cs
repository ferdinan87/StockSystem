using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorCokeRevertEntry
    {
        public string AdditionType { get; set; } = null!;
        public bool Locked { get; set; }
        public DateTime ShiftDate { get; set; }
        public string AdditionVector { get; set; } = null!;
        public DateTime EntryTime { get; set; }
        public double? Value { get; set; }

        public virtual TopFloorCokeRevert TopFloorCokeRevert { get; set; } = null!;
    }
}
