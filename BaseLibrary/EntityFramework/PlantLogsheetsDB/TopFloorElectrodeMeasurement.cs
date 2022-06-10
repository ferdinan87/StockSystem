using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorElectrodeMeasurement
    {
        public TopFloorElectrodeMeasurement()
        {
            TopFloorElectrodeMeasurementEntries = new HashSet<TopFloorElectrodeMeasurementEntry>();
        }

        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public DateTime MeasurementTime { get; set; }

        public virtual TopFloorElectrodeManagement ShiftDateNavigation { get; set; } = null!;
        public virtual ICollection<TopFloorElectrodeMeasurementEntry> TopFloorElectrodeMeasurementEntries { get; set; }
    }
}
