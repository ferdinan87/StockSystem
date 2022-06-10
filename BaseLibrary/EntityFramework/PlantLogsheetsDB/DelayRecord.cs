using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class DelayRecord
    {
        public string DelayCategoryId { get; set; } = null!;
        public string ReferenceKey { get; set; } = null!;
        public DateTime DelayTime { get; set; }
        public string DelayCode { get; set; } = null!;
        public double Duration { get; set; }
        public string? DelayComment { get; set; }

        public virtual DelayAccountingCategory DelayCategory { get; set; } = null!;
    }
}
