using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceTransactionDefinition
    {
        public string Type { get; set; } = null!;
        public string TransactionDefinitionId { get; set; } = null!;
        public string? DalmappingOverride { get; set; }
    }
}
