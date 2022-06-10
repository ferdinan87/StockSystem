using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorDaySummary
    {
        public DateTime ReportingDayDate { get; set; }
        public double? CokeTotal { get; set; }
        public double? RevertTotal { get; set; }
    }
}
