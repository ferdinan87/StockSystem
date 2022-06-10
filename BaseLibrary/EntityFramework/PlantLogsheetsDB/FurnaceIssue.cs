using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceIssue
    {
        public DateTime ShiftDate { get; set; }
        public int IssueId { get; set; }
        public string IssueType { get; set; } = null!;
        public string? Comment { get; set; }

        public virtual FurnaceSupervisorShiftLog ShiftDateNavigation { get; set; } = null!;
    }
}
