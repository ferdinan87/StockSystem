using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterInitialAssay
    {
        public DateTime AssayTime { get; set; }
        public double? Ni { get; set; }
        public double? Cu { get; set; }
        public double? Co { get; set; }
        public double? Fe { get; set; }
        public double? Sulphur { get; set; }
        public double? As { get; set; }
        public double? Se { get; set; }
    }
}
