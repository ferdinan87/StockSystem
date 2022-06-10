using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterTransactionDefinition
    {
        public string Stream { get; set; } = null!;
        public string TransactionDefinitionId { get; set; } = null!;
        public string? DalmappingOverride { get; set; }
    }
}
