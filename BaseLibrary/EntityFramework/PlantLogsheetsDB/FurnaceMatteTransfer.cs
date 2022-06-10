using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceMatteTransfer
    {
        public string TransferRecordId { get; set; } = null!;
        public DateTime? ArrivalTime { get; set; }
        public int ConverterNumber { get; set; }
        public double? BlowNumber { get; set; }
        public double? PotNumber { get; set; }
        public DateTime TimeOrdered { get; set; }
        public double? Mass { get; set; }
        public DateTime? PotAvailable { get; set; }
        public double? TapHolesAvailable { get; set; }
        public double? TapholeUsed { get; set; }
        public DateTime? TapStart { get; set; }
        public string? Mudgun { get; set; }
        public DateTime? MatteRun { get; set; }
        public double? TapDuration { get; set; }
        public double? MatteTemperature { get; set; }
        public double? WaterTemperature { get; set; }
        public DateTime? StopTime { get; set; }
        public double? Duration { get; set; }
        public DateTime? TimeReady { get; set; }
        public bool? LaunderCleaned { get; set; }
        public double? MaxDrillDepth { get; set; }
        public bool? Deflection { get; set; }
        public double? LancingTimeEstimate { get; set; }
        public double? MaxJecuTemp { get; set; }
        public double? ClayInjected { get; set; }
        public bool? SealFailure { get; set; }
        public int? ClayInLaunder { get; set; }
    }
}
