using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterLogCheck
    {
        public ConverterLogCheck()
        {
            TuyereMeasurements = new HashSet<TuyereMeasurement>();
        }

        public string BlowId { get; set; } = null!;
        public bool Pneumatics { get; set; }
        public double? Erturnaround { get; set; }
        public bool Erauto { get; set; }
        public bool Ermanual { get; set; }
        public double? NorthEndWallExpansion { get; set; }
        public double? SouthEndWallExpansion { get; set; }
        public string? PunchBarColour { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
        public virtual ICollection<TuyereMeasurement> TuyereMeasurements { get; set; }
    }
}
