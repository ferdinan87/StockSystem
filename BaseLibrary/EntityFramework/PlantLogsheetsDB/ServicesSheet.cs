using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesSheet
    {
        public ServicesSheet()
        {
            ServicesShiftLogs = new HashSet<ServicesShiftLog>();
        }

        public DateTime SheetDate { get; set; }

        public virtual ServicesAcidPlant ServicesAcidPlant { get; set; } = null!;
        public virtual ServicesArea41AndDam ServicesArea41AndDam { get; set; } = null!;
        public virtual ServicesConcentrateHandling ServicesConcentrateHandling { get; set; } = null!;
        public virtual ServicesFluxPlant ServicesFluxPlant { get; set; } = null!;
        public virtual ServicesHotGasPrecipitator ServicesHotGasPrecipitator { get; set; } = null!;
        public virtual ServicesOxygenPlant ServicesOxygenPlant { get; set; } = null!;
        public virtual ServicesSiteRawAndDemineralisedWater ServicesSiteRawAndDemineralisedWater { get; set; } = null!;
        public virtual ServicesWhbandPowerStation ServicesWhbandPowerStation { get; set; } = null!;
        public virtual ICollection<ServicesShiftLog> ServicesShiftLogs { get; set; }
    }
}
