using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorCokeRevert
    {
        public TopFloorCokeRevert()
        {
            TopFloorCokeRevertEntries = new HashSet<TopFloorCokeRevertEntry>();
        }

        public string AdditionType { get; set; } = null!;
        public DateTime ShiftDate { get; set; }
        public bool Locked { get; set; }

        public virtual TopFloorRoot ShiftDateNavigation { get; set; } = null!;
        public virtual ICollection<TopFloorCokeRevertEntry> TopFloorCokeRevertEntries { get; set; }
    }
}
