using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class BlowDetail
    {
        public BlowDetail()
        {
            BlowFluxDopes = new HashSet<BlowFluxDope>();
        }

        public string BlowId { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Duration { get; set; }
        public double CumulativeDuration { get; set; }
        public double? FluxMass { get; set; }
        public string? FluxType { get; set; }
        public double? DopeMass { get; set; }
        public string? DopeType { get; set; }
        public double? SlagMass { get; set; }
        public string? SlagDestination { get; set; }
        public string QuenchMode { get; set; } = null!;
        public string? Comments { get; set; }

        public virtual BlowSummary Blow { get; set; } = null!;
        public virtual ICollection<BlowFluxDope> BlowFluxDopes { get; set; }
    }
}
