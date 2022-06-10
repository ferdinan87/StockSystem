using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterLogSheet
    {
        public ConverterLogSheet()
        {
            ConverterCharges = new HashSet<ConverterCharge>();
            ConverterEvents = new HashSet<ConverterEvent>();
            ConverterSheetNotes = new HashSet<ConverterSheetNote>();
            ProductionParameters = new HashSet<ProductionParameter>();
        }

        public string BlowId { get; set; } = null!;
        public int ConverterNumber { get; set; }
        public DateTime TimeMatteOrdered { get; set; }
        public string? Status { get; set; }
        public DateTime? ValidationDate { get; set; }
        public int BlowNumber { get; set; }
        public string? Destination { get; set; }
        public double? VpcriticalPathTime { get; set; }
        public double? TotalMassIn { get; set; }
        public double? FfmassTotal { get; set; }
        public string? Skimmer { get; set; }
        public string? Puncher { get; set; }
        public string? VesselPreparer { get; set; }
        public string? Supervisor { get; set; }
        public DateTime? FirstPotIn { get; set; }
        public DateTime? LastPotOut { get; set; }
        public DateTime? PreviousBlowComplete { get; set; }

        public virtual ConverterDetail ConverterNumberNavigation { get; set; } = null!;
        public virtual BlowSummary BlowSummary { get; set; } = null!;
        public virtual ConverterFinalAssay ConverterFinalAssay { get; set; } = null!;
        public virtual ConverterLogCheck ConverterLogCheck { get; set; } = null!;
        public virtual GranulationSummary GranulationSummary { get; set; } = null!;
        public virtual ICollection<ConverterCharge> ConverterCharges { get; set; }
        public virtual ICollection<ConverterEvent> ConverterEvents { get; set; }
        public virtual ICollection<ConverterSheetNote> ConverterSheetNotes { get; set; }
        public virtual ICollection<ProductionParameter> ProductionParameters { get; set; }
    }
}
