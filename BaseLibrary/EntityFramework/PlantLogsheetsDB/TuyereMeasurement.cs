using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TuyereMeasurement
    {
        public string BlowId { get; set; } = null!;
        public int BrickNumber { get; set; }
        public double? Length { get; set; }

        public virtual ConverterLogCheck Blow { get; set; } = null!;
    }
}
