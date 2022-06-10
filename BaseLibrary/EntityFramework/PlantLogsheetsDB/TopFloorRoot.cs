using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorRoot
    {
        public TopFloorRoot()
        {
            TopFloorBinDips = new HashSet<TopFloorBinDip>();
            TopFloorCokeReverts = new HashSet<TopFloorCokeRevert>();
            TopFloorInspections = new HashSet<TopFloorInspection>();
            TopFloorSlagParameters = new HashSet<TopFloorSlagParameter>();
        }

        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }

        public virtual TopFloorElectrodeManagement TopFloorElectrodeManagement { get; set; } = null!;
        public virtual TopFloorShiftReport TopFloorShiftReport { get; set; } = null!;
        public virtual ICollection<TopFloorBinDip> TopFloorBinDips { get; set; }
        public virtual ICollection<TopFloorCokeRevert> TopFloorCokeReverts { get; set; }
        public virtual ICollection<TopFloorInspection> TopFloorInspections { get; set; }
        public virtual ICollection<TopFloorSlagParameter> TopFloorSlagParameters { get; set; }
    }
}
