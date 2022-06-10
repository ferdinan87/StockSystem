using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorElectrodeMeasurementEntry
    {
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public DateTime MeasurementTime { get; set; }
        public string Electrode { get; set; } = null!;
        public double? Outside { get; set; }
        public double? Inside { get; set; }
        public double? CylindersAdded { get; set; }
        public string? Condition { get; set; }

        public virtual TopFloorElectrodeMeasurement TopFloorElectrodeMeasurement { get; set; } = null!;
    }
}
