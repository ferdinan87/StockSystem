using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterSupervisorDaySummary
    {
        public DateTime ReportingDayDate { get; set; }
        public string StreamDescription { get; set; } = null!;
        public double? Mass { get; set; }
        public double? NickelAssay { get; set; }
        public double? CopperAssay { get; set; }
        public double? CobaltAssay { get; set; }
        public double? IronAssay { get; set; }
        public double? SulphurAssay { get; set; }
        public double? ArsenicAssay { get; set; }
        public double? SeleniumAssay { get; set; }
    }
}
