using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesFluxPlant
    {
        public DateTime SheetDate { get; set; }
        public double? Silo1Level { get; set; }
        public double? Silo2Level { get; set; }
        public double? RevertCrushed { get; set; }
        public double? NiInFlux { get; set; }
        public double? MillPower { get; set; }
        public double? TotalFlux { get; set; }
        public double? FinesFed { get; set; }
        public double? FluxToFurnace { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
