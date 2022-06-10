using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSlagDip
    {
        public FurnaceSlagDip()
        {
            FurnaceSlagDipEntries = new HashSet<FurnaceSlagDipEntry>();
        }

        public DateTime ShiftDate { get; set; }
        public string? Tfc { get; set; }
        public double? AverageSlagTemperature { get; set; }

        public virtual ICollection<FurnaceSlagDipEntry> FurnaceSlagDipEntries { get; set; }
    }
}
