using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterSheetNote
    {
        public string BlowId { get; set; } = null!;
        public string NoteType { get; set; } = null!;
        public string? Comment { get; set; }

        public virtual ConverterLogSheet Blow { get; set; } = null!;
    }
}
