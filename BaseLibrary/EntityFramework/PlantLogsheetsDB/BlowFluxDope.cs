using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class BlowFluxDope
    {
        public string BlowId { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public string Type { get; set; } = null!;
        public string Source { get; set; } = null!;
        public double? Mass { get; set; }

        public virtual BlowDetail BlowDetail { get; set; } = null!;
    }
}
