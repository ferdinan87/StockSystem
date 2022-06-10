using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterEvent
    {
        public string BlowId { get; set; } = null!;
        public string EventType { get; set; } = null!;
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public double? TimeElapsed { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
    }
}
