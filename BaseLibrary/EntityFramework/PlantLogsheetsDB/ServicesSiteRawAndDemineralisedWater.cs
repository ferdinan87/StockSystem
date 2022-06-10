using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesSiteRawAndDemineralisedWater
    {
        public DateTime SheetDate { get; set; }
        public double? BindulliWaterReading { get; set; }
        public double? NorthHeadTankLevel { get; set; }
        public double? Demin1TankLevel { get; set; }
        public double? LowLevelStorage { get; set; }
        public double? SouthHeadTankLevel { get; set; }
        public double? Demin2TankLevel { get; set; }
        public double? TotalDeminTonnes { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
