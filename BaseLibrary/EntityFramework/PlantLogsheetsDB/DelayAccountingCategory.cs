using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class DelayAccountingCategory
    {
        public DelayAccountingCategory()
        {
            DelayCodeDetails = new HashSet<DelayCodeDetail>();
            DelayRecords = new HashSet<DelayRecord>();
        }

        public string Id { get; set; } = null!;
        public string Section { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual StandardDelayCodeDetail StandardDelayCodeDetail { get; set; } = null!;
        public virtual ICollection<DelayCodeDetail> DelayCodeDetails { get; set; }
        public virtual ICollection<DelayRecord> DelayRecords { get; set; }
    }
}
