using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterSupervisorOperationalIssue
    {
        public DateTime ReportingDayDate { get; set; }
        public DateTime ShiftDate { get; set; }
        public int IssueId { get; set; }
        public string? IssueDescription { get; set; }
    }
}
