using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesHandoverNote
    {
        public DateTime SheetDate { get; set; }
        public DateTime ShiftDate { get; set; }
        public string? AcidPlant { get; set; }
        public string? HotPrecipitators { get; set; }
        public string? Whb { get; set; }
        public string? PowerStation { get; set; }
        public string? OxygenPlant { get; set; }
        public string? CompressorHouse { get; set; }
        public string? ModulodesSilos { get; set; }
        public string? Area41Dam { get; set; }
        public string? FluxPlant { get; set; }

        public virtual ServicesShiftLog Sh { get; set; } = null!;
    }
}
