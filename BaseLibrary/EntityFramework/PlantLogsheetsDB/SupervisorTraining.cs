using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class SupervisorTraining
    {
        public string Section { get; set; } = null!;
        public DateTime ShiftDate { get; set; }
        public int Id { get; set; }
        public string? Who { get; set; }
        public string? What { get; set; }
        public double? Hours { get; set; }

        public virtual SupervisorShiftDetail S { get; set; } = null!;
    }
}
