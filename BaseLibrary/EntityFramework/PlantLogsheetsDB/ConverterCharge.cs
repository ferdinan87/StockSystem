using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterCharge
    {
        public string BlowId { get; set; } = null!;
        public string PotNumber { get; set; } = null!;
        public string ChargeType { get; set; } = null!;
        public DateTime ChargeTime { get; set; }
        public double? Mass { get; set; }
        public double? CumulativeFfmass { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
    }
}
