using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class FurnaceAdminSetting
    {
        public string SettingItem { get; set; } = null!;
        public string SettingType { get; set; } = null!;
        public string? SerialisedValue { get; set; }
    }
}
