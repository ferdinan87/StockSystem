using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesConcentrateHandling
    {
        public DateTime SheetDate { get; set; }
        public double? WagonsUnloadedKnc { get; set; }
        public double? WagonsUnloadedLmk { get; set; }
        public double? ConcentrateSiloDipsKnc { get; set; }
        public double? ConcentrateSiloDipsLmk { get; set; }
        public DateTime? TimeDip { get; set; }
        public double? ModulodeTonnesTransported { get; set; }
        public double? Amodulode { get; set; }
        public double? Bmodulode { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
