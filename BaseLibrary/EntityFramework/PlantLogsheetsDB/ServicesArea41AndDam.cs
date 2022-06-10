using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesArea41AndDam
    {
        public DateTime SheetDate { get; set; }
        public double? Wattlevel { get; set; }
        public double? Ertlevel { get; set; }
        public double? A41feedrate { get; set; }
        public double? FeAsRatio { get; set; }
        public double? Kcgmwater { get; set; }
        public double? AsInGypsum { get; set; }
        public double? SlagNorth { get; set; }
        public double? SlagSouth { get; set; }
        public double? ResidueEast { get; set; }
        public double? ResidueWest { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
