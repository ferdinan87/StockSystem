using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class BlowSummary
    {
        public BlowSummary()
        {
            BlowDetails = new HashSet<BlowDetail>();
            BlowSamples = new HashSet<BlowSample>();
        }

        public string BlowId { get; set; } = null!;
        public double? BlowMinutesTotal { get; set; }
        public double? StackFluxTotal { get; set; }
        public double? StackDopeTotal { get; set; }
        public double? BoatFluxTotal { get; set; }
        public double? BoatDopeTotal { get; set; }
        public double? TotalSkimmingTime { get; set; }
        public double? TotalSlagToFf { get; set; }
        public double? TotalSlagToConv { get; set; }
        public double? TotalSlagToDump { get; set; }
        public double? MaxTemperature { get; set; }
        public double? TimeOver1280 { get; set; }
        public string? TimeOver1280Comment { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
        public virtual ICollection<BlowDetail> BlowDetails { get; set; }
        public virtual ICollection<BlowSample> BlowSamples { get; set; }
    }
}
