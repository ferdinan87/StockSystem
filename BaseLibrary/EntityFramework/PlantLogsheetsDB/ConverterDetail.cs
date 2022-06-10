using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ConverterDetail
    {
        public ConverterDetail()
        {
            ConverterLogSheets = new HashSet<ConverterLogSheet>();
        }

        public int ConverterNumber { get; set; }
        public int CampaignNumber { get; set; }
        public int CampaignYear { get; set; }
        public int CurrentBlowNumber { get; set; }
        public bool ChecksExpected { get; set; }

        public virtual ICollection<ConverterLogSheet> ConverterLogSheets { get; set; }
    }
}
