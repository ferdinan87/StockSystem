using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class GranulationSummary
    {
        public GranulationSummary()
        {
            GranulationPots = new HashSet<GranulationPot>();
        }

        public string BlowId { get; set; } = null!;
        public DateTime? LastPotTime { get; set; }
        public double? GranulationTime { get; set; }
        public double? TotalMass { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
        public virtual ICollection<GranulationPot> GranulationPots { get; set; }
    }
}
