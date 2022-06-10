using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSlagDipEntry
    {
        public FurnaceSlagDipEntry()
        {
            FurnaceSlagDipLocationEntries = new HashSet<FurnaceSlagDipLocationEntry>();
        }

        public DateTime ShiftDate { get; set; }
        public DateTime EntryTime { get; set; }
        public string? Condition { get; set; }
        public string? Comment { get; set; }
        public double? SlagTemperature { get; set; }

        public virtual FurnaceSlagDip ShiftDateNavigation { get; set; } = null!;
        public virtual ICollection<FurnaceSlagDipLocationEntry> FurnaceSlagDipLocationEntries { get; set; }
    }
}
