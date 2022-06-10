using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesShiftLog
    {
        public DateTime SheetDate { get; set; }
        public DateTime ShiftDate { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
        public virtual ServicesHandoverNote ServicesHandoverNote { get; set; } = null!;
    }
}
