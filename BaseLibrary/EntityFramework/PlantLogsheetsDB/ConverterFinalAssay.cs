using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterFinalAssay
    {
        public DateTime? AssayTime { get; set; }
        public int? BlowNumber { get; set; }
        public int? ConverterNumber { get; set; }
        public string BlowId { get; set; } = null!;
        public double? Ni { get; set; }
        public double? Cu { get; set; }
        public double? Co { get; set; }
        public double? Fe { get; set; }
        public double? Sulphur { get; set; }
        public double? As { get; set; }
        public double? Se { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
    }
}
