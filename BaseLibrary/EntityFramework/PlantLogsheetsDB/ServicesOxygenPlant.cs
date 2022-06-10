using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesOxygenPlant
    {
        public DateTime SheetDate { get; set; }
        public double? OxygenProduced { get; set; }
        public double? FfoxyConsumed { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
