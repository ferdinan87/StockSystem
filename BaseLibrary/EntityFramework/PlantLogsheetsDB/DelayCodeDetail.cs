using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class DelayCodeDetail
    {
        public string DelayCategoryId { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }

        public virtual DelayAccountingCategory DelayCategory { get; set; } = null!;
    }
}
