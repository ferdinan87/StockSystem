using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ProductionParameter
    {
        public string BlowId { get; set; } = null!;
        public string ParameterType { get; set; } = null!;
        public double? ParameterValue { get; set; }
        public string? Comment { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
    }
}
