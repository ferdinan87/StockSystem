using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterSupervisorKpi
    {
        public DateTime ShiftDate { get; set; }
        public string? Knrbin { get; set; }
        public string? ExportBin { get; set; }
        public double? MaterialIntoAisle { get; set; }
        public string? AisleLining { get; set; }
        public string? Haulers { get; set; }
        public double? SkimPotsKnockedOut { get; set; }
        public double? ShiftBlowMinutes { get; set; }
        public double? RevertIn { get; set; }
        public double? RevertOutNorth { get; set; }
        public double? RevertOutSouth { get; set; }
        public string? ProductionPots { get; set; }
        public double? ProductionPotsKnockedOut { get; set; }
        public double? PotsSkulled { get; set; }
        public double? SlagToDump { get; set; }
        public string? SlagComment { get; set; }
        public double? Ffmgranulated { get; set; }
        public double? Ffmnickel { get; set; }
        public string? Ffmcomment { get; set; }
    }
}
