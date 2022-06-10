using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSupervisorDayEndEntry
    {
        public DateTime ReportingDayDate { get; set; }
        public string ItemName { get; set; } = null!;
        public double? Actual { get; set; }
        public double? Variance { get; set; }
        public string? Comment { get; set; }

        public virtual FurnaceSupervisorDayEndTarget ItemNameNavigation { get; set; } = null!;
    }
}
