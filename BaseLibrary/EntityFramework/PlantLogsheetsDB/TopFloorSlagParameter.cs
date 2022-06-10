using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorSlagParameter
    {
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public DateTime MeasurementTime { get; set; }
        public string Parameter { get; set; } = null!;
        public double? ParameterValue { get; set; }

        public virtual TopFloorRoot ShiftDateNavigation { get; set; } = null!;
    }
}
