using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class SupervisorFieldLeadership
    {
        public string Section { get; set; } = null!;
        public DateTime ShiftDate { get; set; }
        public int Id { get; set; }
        public string? LeadershipComment { get; set; }

        public virtual SupervisorShiftDetail S { get; set; } = null!;
    }
}
