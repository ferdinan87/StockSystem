using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceSlagDipLocationEntry
    {
        public DateTime ShiftDate { get; set; }
        public DateTime EntryTime { get; set; }
        public string Location { get; set; } = null!;
        public double? Bu { get; set; }
        public double? Matte { get; set; }
        public double? Overall { get; set; }
        public bool? ClearDip { get; set; }

        public virtual FurnaceSlagDipEntry FurnaceSlagDipEntry { get; set; } = null!;
    }
}
