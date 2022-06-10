using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class TopFloorBinDipLookup
    {
        public string Bin { get; set; } = null!;
        public double DipValue { get; set; }
        public double? Tonnage { get; set; }
    }
}
