using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSupervisorShiftLog
    {
        public FurnaceSupervisorShiftLog()
        {
            FurnaceIssues = new HashSet<FurnaceIssue>();
        }

        public DateTime ShiftDate { get; set; }
        public string? ShiftCode { get; set; }
        public bool? DustDropped { get; set; }
        public string? DustComment { get; set; }

        public virtual ICollection<FurnaceIssue> FurnaceIssues { get; set; }
    }
}
