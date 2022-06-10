using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ValidationRule
    {
        public string Section { get; set; } = null!;
        public string FieldId { get; set; } = null!;
        public double? LowerLimit { get; set; }
        public double? UpperLimit { get; set; }
        public string RuleType { get; set; } = null!;
    }
}
