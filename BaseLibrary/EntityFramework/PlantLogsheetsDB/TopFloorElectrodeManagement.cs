using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorElectrodeManagement
    {
        public TopFloorElectrodeManagement()
        {
            TopFloorElectrodeMeasurements = new HashSet<TopFloorElectrodeMeasurement>();
        }

        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }
        public DateTime? A1casingCompleted { get; set; }
        public DateTime? A2casingCompleted { get; set; }
        public DateTime? A3casingCompleted { get; set; }
        public DateTime? B1casingCompleted { get; set; }
        public DateTime? B2casingCompleted { get; set; }
        public DateTime? B3casingCompleted { get; set; }

        public virtual TopFloorRoot ShiftDateNavigation { get; set; } = null!;
        public virtual ICollection<TopFloorElectrodeMeasurement> TopFloorElectrodeMeasurements { get; set; }
    }
}
