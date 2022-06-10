using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSuperElectrode
    {
        public DateTime ReportingDayDate { get; set; }
        public string ElectrodeType { get; set; } = null!;
        public double? Auto { get; set; }
        public double? AvgMw { get; set; }
        public double? TimeOff { get; set; }
        public double? TimeBakingPaste { get; set; }
        public string? Comment { get; set; }
    }
}
