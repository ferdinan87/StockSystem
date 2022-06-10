using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSuperTap
    {
        public DateTime ReportingDayDate { get; set; }
        public string TapType { get; set; } = null!;
        public string? TodayAndTotal { get; set; }
        public string? Comment { get; set; }
    }
}
