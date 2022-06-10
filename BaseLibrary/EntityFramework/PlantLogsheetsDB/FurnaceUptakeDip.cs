using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceUptakeDip
    {
        public DateTime ShiftDate { get; set; }
        public string Location { get; set; } = null!;
        public DateTime? MeasurementTime { get; set; }
        public double? Buildup { get; set; }
        public double? Fluid { get; set; }
        public string? Comment { get; set; }
    }
}
