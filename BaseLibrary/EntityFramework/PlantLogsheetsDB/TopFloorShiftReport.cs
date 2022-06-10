using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorShiftReport
    {
        public TopFloorShiftReport()
        {
            TopFloorChecks = new HashSet<TopFloorCheck>();
            TopFloorEquipmentChecks = new HashSet<TopFloorEquipmentCheck>();
        }

        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public double? AvarageNiTails { get; set; }
        public double? CokeTotal { get; set; }
        public double? ConveyorDownTime { get; set; }
        public string? Notes { get; set; }
        public string? OperatorOff { get; set; }
        public string? OperatorOn { get; set; }
        public double? RevertTotal { get; set; }
        public int TotalTicks { get; set; }

        public virtual TopFloorRoot ShiftDateNavigation { get; set; } = null!;
        public virtual ICollection<TopFloorCheck> TopFloorChecks { get; set; }
        public virtual ICollection<TopFloorEquipmentCheck> TopFloorEquipmentChecks { get; set; }
    }
}
