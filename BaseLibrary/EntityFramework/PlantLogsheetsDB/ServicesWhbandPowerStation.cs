using System;
using System.Collections.Generic;

namespace BaseLibrary.EntityFramework.PlantLogsheetsDB
{
    public partial class ServicesWhbandPowerStation
    {
        public DateTime SheetDate { get; set; }
        public double? WhbcircWaterFlow { get; set; }
        public double? Bcp1amps { get; set; }
        public double? Bcp2amps { get; set; }
        public double? GecrunMinutes { get; set; }
        public string? SteamBcpsRun { get; set; }
        public double? MaxSteamRate { get; set; }
        public double? AvgSteamRate { get; set; }
        public double? BbcrunMinutes { get; set; }
        public string? SootblowCompleted { get; set; }
        public string? SootblowersRun { get; set; }
        public double? Gecefficiency { get; set; }
        public double? Bbcefficiency { get; set; }
        public string? FfjacketWaterCalled { get; set; }
        public double? Ffjwloss24hr { get; set; }
        public double? Knsgtload { get; set; }
        public double? KnsimportExport { get; set; }
        public string? Bfwp1running { get; set; }
        public string? Bfwp4running { get; set; }
        public string? Bfwp5running { get; set; }
        public string? Bfwp6running { get; set; }
        public string? BfwpsOnStandby { get; set; }
        public double? GecaltLoad { get; set; }
        public double? BbcaltLoad { get; set; }
        public double? GecmwhProduced { get; set; }
        public double? BbcmwhProduced { get; set; }
        public double? SuperHeaterSteamFlow1 { get; set; }
        public double? SuperHeaterSteamFlow2 { get; set; }
        public double? SuperHeaterGasFlow1 { get; set; }
        public double? SuperHeaterGasFlow2 { get; set; }
        public double? SuperHeaterEfficiency1 { get; set; }
        public double? SuperHeaterEfficiency2 { get; set; }

        public virtual ServicesSheet SheetDateNavigation { get; set; } = null!;
    }
}
