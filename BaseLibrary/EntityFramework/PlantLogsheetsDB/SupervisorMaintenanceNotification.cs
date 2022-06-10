using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class SupervisorMaintenanceNotification
    {
        public string Section { get; set; } = null!;
        public DateTime ShiftDate { get; set; }
        public int Id { get; set; }
        public string? Description { get; set; }
        public int? Jrnumber { get; set; }

        public virtual SupervisorShiftDetail S { get; set; } = null!;
    }
}
