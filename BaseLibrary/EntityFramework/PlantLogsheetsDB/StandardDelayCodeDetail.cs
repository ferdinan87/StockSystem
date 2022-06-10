using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class StandardDelayCodeDetail
    {
        public string DelayCategoryId { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int Duration { get; set; }
        public string? Description { get; set; }

        public virtual DelayAccountingCategory DelayCategory { get; set; } = null!;
    }
}
