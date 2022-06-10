using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesHotGasPrecipitator
    {
        public DateTime SheetDate { get; set; }
        public double? SfsecondaryAmpsZone1 { get; set; }
        public double? SfsecondaryAmpsZone2 { get; set; }
        public double? SfsecondaryAmpsZone3 { get; set; }
        public double? LurgiSecondaryAmpsZone1 { get; set; }
        public double? LurgiSecondaryAmpsZone2 { get; set; }
        public double? LurgiSecondaryAmpsZone3 { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
