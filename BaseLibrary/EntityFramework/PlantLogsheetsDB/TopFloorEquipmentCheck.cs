using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorEquipmentCheck
    {
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public string Item { get; set; } = null!;
        public bool? Checked { get; set; }
        public string? NotificationNum { get; set; }

        public virtual TopFloorShiftReport ShiftDateNavigation { get; set; } = null!;
    }
}
