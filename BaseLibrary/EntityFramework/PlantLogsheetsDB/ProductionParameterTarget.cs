using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ProductionParameterTarget
    {
        public string ParameterType { get; set; } = null!;
        public double? ParameterValue { get; set; }
    }
}
