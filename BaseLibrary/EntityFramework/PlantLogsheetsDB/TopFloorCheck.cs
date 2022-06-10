using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorCheck
    {
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public string Item { get; set; } = null!;
        public bool? ItemValue { get; set; }

        public virtual TopFloorShiftReport ShiftDateNavigation { get; set; } = null!;
    }
}
