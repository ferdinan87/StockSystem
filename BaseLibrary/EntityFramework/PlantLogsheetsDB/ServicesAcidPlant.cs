using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesAcidPlant
    {
        public DateTime SheetDate { get; set; }
        public double? So2blowerOperating { get; set; }
        public double? StorageTank1Level { get; set; }
        public double? Rjssolids { get; set; }
        public double? Aaconductivity { get; set; }
        public double? StorageTank2Level { get; set; }
        public double? RjsacidStrength { get; set; }
        public double? Daconductivity { get; set; }
        public double? WaterQuenchOperated { get; set; }
        public double? Rjsbleedrate { get; set; }
        public double? AcidProduced { get; set; }
        public double? StackEmissionsMax { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
