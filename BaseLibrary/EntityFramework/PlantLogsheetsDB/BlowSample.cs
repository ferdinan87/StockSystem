using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class BlowSample
    {
        public string BlowId { get; set; } = null!;
        public DateTime TuyereSampleTime { get; set; }
        public double QuickIron { get; set; }
        public double? MinutesBlowUp { get; set; }
        public int MinsToEndpoint { get; set; }

        public virtual BlowSummary Blow { get; set; } = null!;
    }
}
