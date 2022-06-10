using BaseLibrary.EntityFramework.Configuration;
using BaseLibrary.EntityFramework.PlantLogsheetsDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace BaseLibrary.EntityFramework
{
    public partial class PlantLogsheetsContext : DbContext
    {
        private readonly IConfiguration _config;
        

        public PlantLogsheetsContext(IConfiguration config)
        {
            _config = config;

        }

        public PlantLogsheetsContext(IConfiguration config, DbContextOptions<PlantLogsheetsContext> options)
            : base(options)
        {
            _config = config;
            
        }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config["ConnectionStrings:PlantLogsheetsDB"]);
            }
        }


        public virtual DbSet<BlowDetail> BlowDetails { get; set; } = null!;
        public virtual DbSet<BlowFluxDope> BlowFluxDopes { get; set; } = null!;
        public virtual DbSet<BlowSample> BlowSamples { get; set; } = null!;
        public virtual DbSet<BlowSummary> BlowSummaries { get; set; } = null!;
        public virtual DbSet<CclasregistrationTemplate> CclasregistrationTemplates { get; set; } = null!;
        public virtual DbSet<ConverterAdminSetting> ConverterAdminSettings { get; set; } = null!;
        public virtual DbSet<ConverterCharge> ConverterCharges { get; set; } = null!;
        public virtual DbSet<ConverterDetail> ConverterDetails { get; set; } = null!;
        public virtual DbSet<ConverterEvent> ConverterEvents { get; set; } = null!;
        public virtual DbSet<ConverterFinalAssay> ConverterFinalAssays { get; set; } = null!;
        public virtual DbSet<ConverterInitialAssay> ConverterInitialAssays { get; set; } = null!;
        public virtual DbSet<ConverterLogCheck> ConverterLogChecks { get; set; } = null!;
        public virtual DbSet<ConverterLogSheet> ConverterLogSheets { get; set; } = null!;
        public virtual DbSet<ConverterSheetNote> ConverterSheetNotes { get; set; } = null!;
        public virtual DbSet<ConverterSupervisorDaySummary> ConverterSupervisorDaySummaries { get; set; } = null!;
        public virtual DbSet<ConverterSupervisorKpi> ConverterSupervisorKpis { get; set; } = null!;
        public virtual DbSet<ConverterSupervisorOperationalIssue> ConverterSupervisorOperationalIssues { get; set; } = null!;
        public virtual DbSet<ConverterTransactionDefinition> ConverterTransactionDefinitions { get; set; } = null!;
        public virtual DbSet<DelayAccountingCategory> DelayAccountingCategories { get; set; } = null!;
        public virtual DbSet<DelayCodeDetail> DelayCodeDetails { get; set; } = null!;
        public virtual DbSet<DelayRecord> DelayRecords { get; set; } = null!;
        public virtual DbSet<FurnaceAdminSetting> FurnaceAdminSettings { get; set; } = null!;
        public virtual DbSet<FurnaceIssue> FurnaceIssues { get; set; } = null!;
        public virtual DbSet<FurnaceMatteTransfer> FurnaceMatteTransfers { get; set; } = null!;
        public virtual DbSet<FurnaceSlagDip> FurnaceSlagDips { get; set; } = null!;
        public virtual DbSet<FurnaceSlagDipConditionLookup> FurnaceSlagDipConditionLookups { get; set; } = null!;
        public virtual DbSet<FurnaceSlagDipEntry> FurnaceSlagDipEntries { get; set; } = null!;
        public virtual DbSet<FurnaceSlagDipLocationEntry> FurnaceSlagDipLocationEntries { get; set; } = null!;
        public virtual DbSet<FurnaceSuperElectrode> FurnaceSuperElectrodes { get; set; } = null!;
        public virtual DbSet<FurnaceSuperTap> FurnaceSuperTaps { get; set; } = null!;
        public virtual DbSet<FurnaceSupervisorDayEndEntry> FurnaceSupervisorDayEndEntries { get; set; } = null!;
        public virtual DbSet<FurnaceSupervisorDayEndTarget> FurnaceSupervisorDayEndTargets { get; set; } = null!;
        public virtual DbSet<FurnaceSupervisorShiftLog> FurnaceSupervisorShiftLogs { get; set; } = null!;
        public virtual DbSet<FurnaceTransactionDefinition> FurnaceTransactionDefinitions { get; set; } = null!;
        public virtual DbSet<FurnaceUptakeDip> FurnaceUptakeDips { get; set; } = null!;
        public virtual DbSet<GlobalSetting> GlobalSettings { get; set; } = null!;
        public virtual DbSet<GranulationPot> GranulationPots { get; set; } = null!;
        public virtual DbSet<GranulationSummary> GranulationSummaries { get; set; } = null!;
        public virtual DbSet<ProductionParameter> ProductionParameters { get; set; } = null!;
        public virtual DbSet<ProductionParameterTarget> ProductionParameterTargets { get; set; } = null!;
        public virtual DbSet<ServicesAcidPlant> ServicesAcidPlants { get; set; } = null!;
        public virtual DbSet<ServicesArea41AndDam> ServicesArea41AndDams { get; set; } = null!;
        public virtual DbSet<ServicesConcentrateHandling> ServicesConcentrateHandlings { get; set; } = null!;
        public virtual DbSet<ServicesFluxPlant> ServicesFluxPlants { get; set; } = null!;
        public virtual DbSet<ServicesHandoverNote> ServicesHandoverNotes { get; set; } = null!;
        public virtual DbSet<ServicesHotGasPrecipitator> ServicesHotGasPrecipitators { get; set; } = null!;
        public virtual DbSet<ServicesOxygenPlant> ServicesOxygenPlants { get; set; } = null!;
        public virtual DbSet<ServicesSheet> ServicesSheets { get; set; } = null!;
        public virtual DbSet<ServicesShiftLog> ServicesShiftLogs { get; set; } = null!;
        public virtual DbSet<ServicesSiteRawAndDemineralisedWater> ServicesSiteRawAndDemineralisedWaters { get; set; } = null!;
        public virtual DbSet<ServicesWhbandPowerStation> ServicesWhbandPowerStations { get; set; } = null!;
        public virtual DbSet<StandardDelayCodeDetail> StandardDelayCodeDetails { get; set; } = null!;
        public virtual DbSet<SupervisorAbsence> SupervisorAbsences { get; set; } = null!;
        public virtual DbSet<SupervisorFieldLeadership> SupervisorFieldLeaderships { get; set; } = null!;
        public virtual DbSet<SupervisorIncidentAccident> SupervisorIncidentAccidents { get; set; } = null!;
        public virtual DbSet<SupervisorMaintenanceNotification> SupervisorMaintenanceNotifications { get; set; } = null!;
        public virtual DbSet<SupervisorShiftDetail> SupervisorShiftDetails { get; set; } = null!;
        public virtual DbSet<SupervisorTopIssue> SupervisorTopIssues { get; set; } = null!;
        public virtual DbSet<SupervisorTraining> SupervisorTrainings { get; set; } = null!;
        public virtual DbSet<SupervisorUpcomingAction> SupervisorUpcomingActions { get; set; } = null!;
        public virtual DbSet<TopFloorAdminSetting> TopFloorAdminSettings { get; set; } = null!;
        public virtual DbSet<TopFloorBinDip> TopFloorBinDips { get; set; } = null!;
        public virtual DbSet<TopFloorBinDipLookup> TopFloorBinDipLookups { get; set; } = null!;
        public virtual DbSet<TopFloorCheck> TopFloorChecks { get; set; } = null!;
        public virtual DbSet<TopFloorCokeRevert> TopFloorCokeReverts { get; set; } = null!;
        public virtual DbSet<TopFloorCokeRevertEntry> TopFloorCokeRevertEntries { get; set; } = null!;
        public virtual DbSet<TopFloorDaySummary> TopFloorDaySummaries { get; set; } = null!;
        public virtual DbSet<TopFloorElectrodeManagement> TopFloorElectrodeManagements { get; set; } = null!;
        public virtual DbSet<TopFloorElectrodeMeasurement> TopFloorElectrodeMeasurements { get; set; } = null!;
        public virtual DbSet<TopFloorElectrodeMeasurementEntry> TopFloorElectrodeMeasurementEntries { get; set; } = null!;
        public virtual DbSet<TopFloorEquipmentCheck> TopFloorEquipmentChecks { get; set; } = null!;
        public virtual DbSet<TopFloorInspection> TopFloorInspections { get; set; } = null!;
        public virtual DbSet<TopFloorRoot> TopFloorRoots { get; set; } = null!;
        public virtual DbSet<TopFloorShiftReport> TopFloorShiftReports { get; set; } = null!;
        public virtual DbSet<TopFloorSlagParameter> TopFloorSlagParameters { get; set; } = null!;
        public virtual DbSet<TuyereMeasurement> TuyereMeasurements { get; set; } = null!;
        public virtual DbSet<ValidationRule> ValidationRules { get; set; } = null!;

        public virtual DbSet<LoginToken> LoginTokens { get; set; } = null!;

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CS_AS");

            modelBuilder.Entity<BlowDetail>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.StartTime })
                    .HasName("PK_ConverterBlowDetail");

                entity.ToTable("BlowDetail", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Comments).HasColumnType("ntext");

                entity.Property(e => e.DopeType).HasMaxLength(10);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FluxType).HasMaxLength(10);

                entity.Property(e => e.QuenchMode)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.SlagDestination).HasMaxLength(10);

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.BlowDetails)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_Blow_Detail");
            });

            modelBuilder.Entity<BlowFluxDope>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.StartTime, e.Type, e.Source })
                    .HasName("PK_ConverterBlowFluxDope");

                entity.ToTable("BlowFluxDope", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.Property(e => e.Source).HasMaxLength(10);

                entity.HasOne(d => d.BlowDetail)
                    .WithMany(p => p.BlowFluxDopes)
                    .HasForeignKey(d => new { d.BlowId, d.StartTime })
                    .HasConstraintName("FK_Blow_FluxDope");
            });

            modelBuilder.Entity<BlowSample>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.TuyereSampleTime })
                    .HasName("PK_ConverterBlowSample");

                entity.ToTable("BlowSample", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.TuyereSampleTime).HasColumnType("datetime");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.BlowSamples)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_Blow_Sample");
            });

            modelBuilder.Entity<BlowSummary>(entity =>
            {
                entity.HasKey(e => e.BlowId);

                entity.ToTable("BlowSummary", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.TimeOver1280Comment).HasColumnType("ntext");

                entity.Property(e => e.TotalSlagToFf).HasColumnName("TotalSlagToFF");

                entity.HasOne(d => d.Blow)
                    .WithOne(p => p.BlowSummary)
                    .HasForeignKey<BlowSummary>(d => d.BlowId)
                    .HasConstraintName("FK_ConverterSheet_BlowSummary");
            });

            modelBuilder.Entity<CclasregistrationTemplate>(entity =>
            {
                entity.HasKey(e => e.StreamCode);

                entity.ToTable("CCLASRegistrationTemplate", "kns");

                entity.Property(e => e.StreamCode).HasMaxLength(50);

                entity.Property(e => e.LabCode).HasMaxLength(50);

                entity.Property(e => e.StreamSchedule).HasColumnType("ntext");
            });

            modelBuilder.Entity<ConverterAdminSetting>(entity =>
            {
                entity.HasKey(e => e.SettingItem);

                entity.ToTable("ConverterAdminSetting", "kns");

                entity.Property(e => e.SettingItem).HasMaxLength(50);

                entity.Property(e => e.SerialisedValue).HasColumnType("ntext");

                entity.Property(e => e.SettingType).HasMaxLength(20);
            });

            modelBuilder.Entity<ConverterCharge>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.PotNumber });

                entity.ToTable("ConverterCharge", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.PotNumber).HasMaxLength(50);

                entity.Property(e => e.ChargeTime).HasColumnType("datetime");

                entity.Property(e => e.ChargeType).HasMaxLength(20);

                entity.Property(e => e.CumulativeFfmass).HasColumnName("CumulativeFFMass");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.ConverterCharges)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_ConverterSheet_Charge");
            });

            modelBuilder.Entity<ConverterDetail>(entity =>
            {
                entity.HasKey(e => e.ConverterNumber)
                    .HasName("PK_Converter");

                entity.ToTable("ConverterDetail", "kns");

                entity.Property(e => e.ConverterNumber).ValueGeneratedNever();
            });

            modelBuilder.Entity<ConverterEvent>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.EventType });

                entity.ToTable("ConverterEvent", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.EventType).HasMaxLength(20);

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.ConverterEvents)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_ConverterSheet_Event");
            });

            modelBuilder.Entity<ConverterFinalAssay>(entity =>
            {
                entity.HasKey(e => e.BlowId);

                entity.ToTable("ConverterFinalAssay", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.AssayTime).HasColumnType("datetime");

                entity.HasOne(d => d.Blow)
                    .WithOne(p => p.ConverterFinalAssay)
                    .HasForeignKey<ConverterFinalAssay>(d => d.BlowId)
                    .HasConstraintName("FK_ConverterSheet_FinalAssay");
            });

            modelBuilder.Entity<ConverterInitialAssay>(entity =>
            {
                entity.HasKey(e => e.AssayTime);

                entity.ToTable("ConverterInitialAssay", "kns");

                entity.Property(e => e.AssayTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ConverterLogCheck>(entity =>
            {
                entity.HasKey(e => e.BlowId);

                entity.ToTable("ConverterLogCheck", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.Erauto).HasColumnName("ERAuto");

                entity.Property(e => e.Ermanual).HasColumnName("ERManual");

                entity.Property(e => e.Erturnaround).HasColumnName("ERTurnaround");

                entity.Property(e => e.PunchBarColour).HasMaxLength(20);

                entity.HasOne(d => d.Blow)
                    .WithOne(p => p.ConverterLogCheck)
                    .HasForeignKey<ConverterLogCheck>(d => d.BlowId)
                    .HasConstraintName("FK_ConverterSheet_Check");
            });

            modelBuilder.Entity<ConverterLogSheet>(entity =>
            {
                entity.HasKey(e => e.BlowId)
                    .IsClustered(false);

                entity.ToTable("ConverterLogSheet", "kns");

                entity.HasIndex(e => new { e.ConverterNumber, e.BlowNumber, e.TimeMatteOrdered }, "UQ_ConverterSheet")
                    .IsUnique();

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.FfmassTotal).HasColumnName("FFMassTotal");

                entity.Property(e => e.FirstPotIn).HasColumnType("datetime");

                entity.Property(e => e.LastPotOut).HasColumnType("datetime");

                entity.Property(e => e.PreviousBlowComplete).HasColumnType("datetime");

                entity.Property(e => e.Puncher).HasMaxLength(100);

                entity.Property(e => e.Skimmer).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(100);

                entity.Property(e => e.Supervisor).HasMaxLength(100);

                entity.Property(e => e.TimeMatteOrdered).HasColumnType("datetime");

                entity.Property(e => e.ValidationDate).HasColumnType("datetime");

                entity.Property(e => e.VesselPreparer).HasMaxLength(100);

                entity.Property(e => e.VpcriticalPathTime).HasColumnName("VPCriticalPathTime");

                entity.HasOne(d => d.ConverterNumberNavigation)
                    .WithMany(p => p.ConverterLogSheets)
                    .HasForeignKey(d => d.ConverterNumber)
                    .HasConstraintName("FK_ConverterSheet_Converter");
            });

            modelBuilder.Entity<ConverterSheetNote>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.NoteType })
                    .HasName("PK_ConverterNote");

                entity.ToTable("ConverterSheetNotes", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.NoteType).HasMaxLength(20);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.ConverterSheetNotes)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_ConverterSheet_Notes");
            });

            modelBuilder.Entity<ConverterSupervisorDaySummary>(entity =>
            {
                entity.HasKey(e => new { e.ReportingDayDate, e.StreamDescription })
                    .HasName("PK_ConverterDaySummary");

                entity.ToTable("ConverterSupervisorDaySummary", "kns");

                entity.Property(e => e.ReportingDayDate).HasColumnType("datetime");

                entity.Property(e => e.StreamDescription).HasMaxLength(100);
            });

            modelBuilder.Entity<ConverterSupervisorKpi>(entity =>
            {
                entity.HasKey(e => e.ShiftDate);

                entity.ToTable("ConverterSupervisorKPI", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.AisleLining).HasColumnType("ntext");

                entity.Property(e => e.ExportBin).HasMaxLength(200);

                entity.Property(e => e.Ffmcomment)
                    .HasColumnType("ntext")
                    .HasColumnName("FFMComment");

                entity.Property(e => e.Ffmgranulated).HasColumnName("FFMGranulated");

                entity.Property(e => e.Ffmnickel).HasColumnName("FFMNickel");

                entity.Property(e => e.Haulers).HasColumnType("ntext");

                entity.Property(e => e.Knrbin)
                    .HasMaxLength(200)
                    .HasColumnName("KNRBin");

                entity.Property(e => e.ProductionPots).HasMaxLength(200);

                entity.Property(e => e.SlagComment).HasColumnType("ntext");
            });

            modelBuilder.Entity<ConverterSupervisorOperationalIssue>(entity =>
            {
                entity.HasKey(e => new { e.ReportingDayDate, e.ShiftDate, e.IssueId })
                    .HasName("PK_OperationalIssue");

                entity.ToTable("ConverterSupervisorOperationalIssue", "kns");

                entity.Property(e => e.ReportingDayDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.IssueDescription).HasColumnType("ntext");
            });

            modelBuilder.Entity<ConverterTransactionDefinition>(entity =>
            {
                entity.HasKey(e => e.Stream)
                    .HasName("PK_ConvTxDef");

                entity.ToTable("ConverterTransactionDefinition", "kns");

                entity.Property(e => e.Stream).HasMaxLength(50);

                entity.Property(e => e.DalmappingOverride)
                    .HasMaxLength(255)
                    .HasColumnName("DALMappingOverride");

                entity.Property(e => e.TransactionDefinitionId)
                    .HasMaxLength(128)
                    .HasColumnName("TransactionDefinitionID");
            });

            modelBuilder.Entity<DelayAccountingCategory>(entity =>
            {
                entity.ToTable("DelayAccountingCategory", "kns");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Section).HasMaxLength(20);
            });

            modelBuilder.Entity<DelayCodeDetail>(entity =>
            {
                entity.HasKey(e => new { e.DelayCategoryId, e.Code });

                entity.ToTable("DelayCodeDetail", "kns");

                entity.Property(e => e.DelayCategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("DelayCategoryID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.HasOne(d => d.DelayCategory)
                    .WithMany(p => p.DelayCodeDetails)
                    .HasForeignKey(d => d.DelayCategoryId)
                    .HasConstraintName("FK_DelayCode_Category");
            });

            modelBuilder.Entity<DelayRecord>(entity =>
            {
                entity.HasKey(e => new { e.DelayCategoryId, e.ReferenceKey, e.DelayTime, e.DelayCode });

                entity.ToTable("DelayRecords", "kns");

                entity.Property(e => e.DelayCategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("DelayCategoryID");

                entity.Property(e => e.ReferenceKey).HasMaxLength(300);

                entity.Property(e => e.DelayTime).HasColumnType("datetime");

                entity.Property(e => e.DelayCode).HasMaxLength(20);

                entity.Property(e => e.DelayComment).HasColumnType("ntext");

                entity.HasOne(d => d.DelayCategory)
                    .WithMany(p => p.DelayRecords)
                    .HasForeignKey(d => d.DelayCategoryId)
                    .HasConstraintName("FK_DelayCategory_Records");
            });

            modelBuilder.Entity<FurnaceAdminSetting>(entity =>
            {
                entity.HasKey(e => e.SettingItem)
                    .HasName("PK_FurnaceSettings");

                entity.ToTable("FurnaceAdminSettings", "kns");

                entity.Property(e => e.SettingItem).HasMaxLength(50);

                entity.Property(e => e.SerialisedValue).HasColumnType("ntext");

                entity.Property(e => e.SettingType).HasMaxLength(20);
            });

            modelBuilder.Entity<FurnaceIssue>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.IssueId });

                entity.ToTable("FurnaceIssue", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.IssueType).HasMaxLength(20);

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.FurnaceIssues)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_FurnSuperLog_Issue");
            });

            modelBuilder.Entity<FurnaceMatteTransfer>(entity =>
            {
                entity.HasKey(e => e.TransferRecordId)
                    .HasName("PK_MatteTransferDetail");

                entity.ToTable("FurnaceMatteTransfer", "kns");

                entity.Property(e => e.TransferRecordId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("TransferRecordID")
                    .IsFixedLength();

                entity.Property(e => e.ArrivalTime).HasColumnType("datetime");

                entity.Property(e => e.MatteRun).HasColumnType("datetime");

                entity.Property(e => e.MaxJecuTemp).HasColumnName("MaxJECuTemp");

                entity.Property(e => e.Mudgun).HasMaxLength(20);

                entity.Property(e => e.PotAvailable).HasColumnType("datetime");

                entity.Property(e => e.StopTime).HasColumnType("datetime");

                entity.Property(e => e.TapStart).HasColumnType("datetime");

                entity.Property(e => e.TimeOrdered).HasColumnType("datetime");

                entity.Property(e => e.TimeReady).HasColumnType("datetime");
            });

            modelBuilder.Entity<FurnaceSlagDip>(entity =>
            {
                entity.HasKey(e => e.ShiftDate);

                entity.ToTable("FurnaceSlagDip", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Tfc)
                    .HasMaxLength(200)
                    .HasColumnName("TFC");
            });

            modelBuilder.Entity<FurnaceSlagDipConditionLookup>(entity =>
            {
                entity.HasKey(e => e.ConditionCode);

                entity.ToTable("FurnaceSlagDipConditionLookup", "kns");

                entity.Property(e => e.ConditionCode).HasMaxLength(100);
            });

            modelBuilder.Entity<FurnaceSlagDipEntry>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.EntryTime });

                entity.ToTable("FurnaceSlagDipEntry", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.Condition).HasMaxLength(200);

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.FurnaceSlagDipEntries)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_FurnaceSlagDip_Entry");
            });

            modelBuilder.Entity<FurnaceSlagDipLocationEntry>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.EntryTime, e.Location })
                    .HasName("PK_SlagDipLocEntry");

                entity.ToTable("FurnaceSlagDipLocationEntry", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(10);

                entity.Property(e => e.Bu).HasColumnName("BU");

                entity.HasOne(d => d.FurnaceSlagDipEntry)
                    .WithMany(p => p.FurnaceSlagDipLocationEntries)
                    .HasForeignKey(d => new { d.ShiftDate, d.EntryTime })
                    .HasConstraintName("FK_SlagDipEntry_LocEntry");
            });

            modelBuilder.Entity<FurnaceSuperElectrode>(entity =>
            {
                entity.HasKey(e => new { e.ReportingDayDate, e.ElectrodeType });

                entity.ToTable("FurnaceSuperElectrode", "kns");

                entity.Property(e => e.ReportingDayDate).HasColumnType("datetime");

                entity.Property(e => e.ElectrodeType).HasMaxLength(20);

                entity.Property(e => e.AvgMw).HasColumnName("AvgMW");

                entity.Property(e => e.Comment).HasColumnType("ntext");
            });

            modelBuilder.Entity<FurnaceSuperTap>(entity =>
            {
                entity.HasKey(e => new { e.ReportingDayDate, e.TapType });

                entity.ToTable("FurnaceSuperTap", "kns");

                entity.Property(e => e.ReportingDayDate).HasColumnType("datetime");

                entity.Property(e => e.TapType).HasMaxLength(20);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.TodayAndTotal).HasMaxLength(100);
            });

            modelBuilder.Entity<FurnaceSupervisorDayEndEntry>(entity =>
            {
                entity.HasKey(e => new { e.ReportingDayDate, e.ItemName });

                entity.ToTable("FurnaceSupervisorDayEndEntry", "kns");

                entity.Property(e => e.ReportingDayDate).HasColumnType("datetime");

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.HasOne(d => d.ItemNameNavigation)
                    .WithMany(p => p.FurnaceSupervisorDayEndEntries)
                    .HasForeignKey(d => d.ItemName)
                    .HasConstraintName("FK_DayEndItem_Entry");
            });

            modelBuilder.Entity<FurnaceSupervisorDayEndTarget>(entity =>
            {
                entity.HasKey(e => e.ItemName);

                entity.ToTable("FurnaceSupervisorDayEndTarget", "kns");

                entity.Property(e => e.ItemName).HasMaxLength(100);
            });

            modelBuilder.Entity<FurnaceSupervisorShiftLog>(entity =>
            {
                entity.HasKey(e => e.ShiftDate);

                entity.ToTable("FurnaceSupervisorShiftLog", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.DustComment).HasColumnType("ntext");

                entity.Property(e => e.ShiftCode).HasMaxLength(10);
            });

            modelBuilder.Entity<FurnaceTransactionDefinition>(entity =>
            {
                entity.HasKey(e => e.Type)
                    .HasName("PK_FFTxDef");

                entity.ToTable("FurnaceTransactionDefinitions", "kns");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.DalmappingOverride)
                    .HasMaxLength(255)
                    .HasColumnName("DALMappingOverride");

                entity.Property(e => e.TransactionDefinitionId)
                    .HasMaxLength(256)
                    .HasColumnName("TransactionDefinitionID");
            });

            modelBuilder.Entity<FurnaceUptakeDip>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.Location });

                entity.ToTable("FurnaceUptakeDip", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.MeasurementTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GlobalSetting>(entity =>
            {
                entity.HasKey(e => e.SettingItem);

                entity.ToTable("GlobalSettings", "kns");

                entity.Property(e => e.SettingItem).HasMaxLength(50);

                entity.Property(e => e.SerialisedValue).HasColumnType("ntext");

                entity.Property(e => e.SettingType).HasMaxLength(20);
            });

            modelBuilder.Entity<GranulationPot>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.PotNumber });

                entity.ToTable("GranulationPot", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.GranulationPots)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_Granulation_Pot");
            });

            modelBuilder.Entity<GranulationSummary>(entity =>
            {
                entity.HasKey(e => e.BlowId)
                    .HasName("PK_ConverterGranulation");

                entity.ToTable("GranulationSummary", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.LastPotTime).HasColumnType("datetime");

                entity.HasOne(d => d.Blow)
                    .WithOne(p => p.GranulationSummary)
                    .HasForeignKey<GranulationSummary>(d => d.BlowId)
                    .HasConstraintName("FK_Converter_Granulation");
            });

            modelBuilder.Entity<ProductionParameter>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.ParameterType })
                    .HasName("PK_ConverterProdParam");

                entity.ToTable("ProductionParameter", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.Property(e => e.ParameterType).HasMaxLength(100);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.ProductionParameters)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_Converter_ProdParam");
            });

            modelBuilder.Entity<ProductionParameterTarget>(entity =>
            {
                entity.HasKey(e => e.ParameterType)
                    .HasName("PK_ParamTarget");

                entity.ToTable("ProductionParameterTarget", "kns");

                entity.Property(e => e.ParameterType).HasMaxLength(50);
            });

            modelBuilder.Entity<ServicesAcidPlant>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_AcidPlant");

                entity.ToTable("ServicesAcidPlant", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.Aaconductivity).HasColumnName("AAConductivity");

                entity.Property(e => e.Daconductivity).HasColumnName("DAConductivity");

                entity.Property(e => e.RjsacidStrength).HasColumnName("RJSAcidStrength");

                entity.Property(e => e.Rjsbleedrate).HasColumnName("RJSBleedrate");

                entity.Property(e => e.Rjssolids).HasColumnName("RJSSolids");

                entity.Property(e => e.So2blowerOperating).HasColumnName("SO2BlowerOperating");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesAcidPlant)
                    .HasForeignKey<ServicesAcidPlant>(d => d.SheetDate)
                    .HasConstraintName("FK_AcidPlant_ServicesSheet");
            });

            modelBuilder.Entity<ServicesArea41AndDam>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_Area41AndDams");

                entity.ToTable("ServicesArea41AndDams", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.A41feedrate).HasColumnName("A41Feedrate");

                entity.Property(e => e.Ertlevel).HasColumnName("ERTLevel");

                entity.Property(e => e.Kcgmwater).HasColumnName("KCGMWater");

                entity.Property(e => e.Wattlevel).HasColumnName("WATTLevel");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesArea41AndDam)
                    .HasForeignKey<ServicesArea41AndDam>(d => d.SheetDate)
                    .HasConstraintName("FK_Area41AndDams_ServicesSheet");
            });

            modelBuilder.Entity<ServicesConcentrateHandling>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_ConcentrateHandling");

                entity.ToTable("ServicesConcentrateHandling", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.Amodulode).HasColumnName("AModulode");

                entity.Property(e => e.Bmodulode).HasColumnName("BModulode");

                entity.Property(e => e.ConcentrateSiloDipsKnc).HasColumnName("ConcentrateSiloDipsKNC");

                entity.Property(e => e.ConcentrateSiloDipsLmk).HasColumnName("ConcentrateSiloDipsLMK");

                entity.Property(e => e.TimeDip).HasColumnType("datetime");

                entity.Property(e => e.WagonsUnloadedKnc).HasColumnName("WagonsUnloadedKNC");

                entity.Property(e => e.WagonsUnloadedLmk).HasColumnName("WagonsUnloadedLMK");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesConcentrateHandling)
                    .HasForeignKey<ServicesConcentrateHandling>(d => d.SheetDate)
                    .HasConstraintName("FK_ConcentrateHandling_ServicesSheet");
            });

            modelBuilder.Entity<ServicesFluxPlant>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_FluxPlant");

                entity.ToTable("ServicesFluxPlant", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesFluxPlant)
                    .HasForeignKey<ServicesFluxPlant>(d => d.SheetDate)
                    .HasConstraintName("FK_FluxPlant_ServicesSheet");
            });

            modelBuilder.Entity<ServicesHandoverNote>(entity =>
            {
                entity.HasKey(e => new { e.SheetDate, e.ShiftDate })
                    .HasName("PK_HandoverNote");

                entity.ToTable("ServicesHandoverNote", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.AcidPlant).HasColumnType("ntext");

                entity.Property(e => e.Area41Dam).HasColumnType("ntext");

                entity.Property(e => e.CompressorHouse).HasColumnType("ntext");

                entity.Property(e => e.FluxPlant).HasColumnType("ntext");

                entity.Property(e => e.HotPrecipitators).HasColumnType("ntext");

                entity.Property(e => e.ModulodesSilos).HasColumnType("ntext");

                entity.Property(e => e.OxygenPlant).HasColumnType("ntext");

                entity.Property(e => e.PowerStation).HasColumnType("ntext");

                entity.Property(e => e.Whb)
                    .HasColumnType("ntext")
                    .HasColumnName("WHB");

                entity.HasOne(d => d.Sh)
                    .WithOne(p => p.ServicesHandoverNote)
                    .HasForeignKey<ServicesHandoverNote>(d => new { d.SheetDate, d.ShiftDate })
                    .HasConstraintName("FK_HandoverNote_ServicesShift");
            });

            modelBuilder.Entity<ServicesHotGasPrecipitator>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_HotGasPrecipitator");

                entity.ToTable("ServicesHotGasPrecipitator", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.SfsecondaryAmpsZone1).HasColumnName("SFSecondaryAmpsZone1");

                entity.Property(e => e.SfsecondaryAmpsZone2).HasColumnName("SFSecondaryAmpsZone2");

                entity.Property(e => e.SfsecondaryAmpsZone3).HasColumnName("SFSecondaryAmpsZone3");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesHotGasPrecipitator)
                    .HasForeignKey<ServicesHotGasPrecipitator>(d => d.SheetDate)
                    .HasConstraintName("FK_HotGasPrecipitator_ServicesSheet");
            });

            modelBuilder.Entity<ServicesOxygenPlant>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_OxygenPlant");

                entity.ToTable("ServicesOxygenPlant", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.FfoxyConsumed).HasColumnName("FFOxyConsumed");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesOxygenPlant)
                    .HasForeignKey<ServicesOxygenPlant>(d => d.SheetDate)
                    .HasConstraintName("FK_OxygenPlant_ServicesSheet");
            });

            modelBuilder.Entity<ServicesSheet>(entity =>
            {
                entity.HasKey(e => e.SheetDate);

                entity.ToTable("ServicesSheet", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServicesShiftLog>(entity =>
            {
                entity.HasKey(e => new { e.SheetDate, e.ShiftDate });

                entity.ToTable("ServicesShiftLog", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithMany(p => p.ServicesShiftLogs)
                    .HasForeignKey(d => d.SheetDate)
                    .HasConstraintName("FK_Services_ShiftLog");
            });

            modelBuilder.Entity<ServicesSiteRawAndDemineralisedWater>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_SiteRawAndDemineralisedWater");

                entity.ToTable("ServicesSiteRawAndDemineralisedWater", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesSiteRawAndDemineralisedWater)
                    .HasForeignKey<ServicesSiteRawAndDemineralisedWater>(d => d.SheetDate)
                    .HasConstraintName("FK_SiteRawAndDemineralisedWater_ServicesSheet");
            });

            modelBuilder.Entity<ServicesWhbandPowerStation>(entity =>
            {
                entity.HasKey(e => e.SheetDate)
                    .HasName("PK_WHBAndPowerStation");

                entity.ToTable("ServicesWHBAndPowerStation", "kns");

                entity.Property(e => e.SheetDate).HasColumnType("datetime");

                entity.Property(e => e.BbcaltLoad).HasColumnName("BBCAltLoad");

                entity.Property(e => e.Bbcefficiency).HasColumnName("BBCEfficiency");

                entity.Property(e => e.BbcmwhProduced).HasColumnName("BBCMWhProduced");

                entity.Property(e => e.BbcrunMinutes).HasColumnName("BBCRunMinutes");

                entity.Property(e => e.Bcp1amps).HasColumnName("BCP1Amps");

                entity.Property(e => e.Bcp2amps).HasColumnName("BCP2Amps");

                entity.Property(e => e.Bfwp1running)
                    .HasMaxLength(10)
                    .HasColumnName("BFWP1Running");

                entity.Property(e => e.Bfwp4running)
                    .HasMaxLength(10)
                    .HasColumnName("BFWP4Running");

                entity.Property(e => e.Bfwp5running)
                    .HasMaxLength(10)
                    .HasColumnName("BFWP5Running");

                entity.Property(e => e.Bfwp6running)
                    .HasMaxLength(10)
                    .HasColumnName("BFWP6Running");

                entity.Property(e => e.BfwpsOnStandby)
                    .HasColumnType("ntext")
                    .HasColumnName("BFWPsOnStandby");

                entity.Property(e => e.FfjacketWaterCalled)
                    .HasColumnType("ntext")
                    .HasColumnName("FFJacketWaterCalled");

                entity.Property(e => e.Ffjwloss24hr).HasColumnName("FFJWLoss24hr");

                entity.Property(e => e.GecaltLoad).HasColumnName("GECAltLoad");

                entity.Property(e => e.Gecefficiency).HasColumnName("GECEfficiency");

                entity.Property(e => e.GecmwhProduced).HasColumnName("GECMWhProduced");

                entity.Property(e => e.GecrunMinutes).HasColumnName("GECRunMinutes");

                entity.Property(e => e.Knsgtload).HasColumnName("KNSGTLoad");

                entity.Property(e => e.KnsimportExport).HasColumnName("KNSImportExport");

                entity.Property(e => e.SootblowCompleted).HasColumnType("ntext");

                entity.Property(e => e.SootblowersRun).HasColumnType("ntext");

                entity.Property(e => e.SteamBcpsRun)
                    .HasColumnType("ntext")
                    .HasColumnName("SteamBCPsRun");

                entity.Property(e => e.WhbcircWaterFlow).HasColumnName("WHBCircWaterFlow");

                entity.HasOne(d => d.SheetDateNavigation)
                    .WithOne(p => p.ServicesWhbandPowerStation)
                    .HasForeignKey<ServicesWhbandPowerStation>(d => d.SheetDate)
                    .HasConstraintName("FK_WHBAndPowerStation_ServicesSheet");
            });

            modelBuilder.Entity<StandardDelayCodeDetail>(entity =>
            {
                entity.HasKey(e => e.DelayCategoryId)
                    .HasName("PK_StdDelayCodeDetail");

                entity.ToTable("StandardDelayCodeDetail", "kns");

                entity.Property(e => e.DelayCategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("DelayCategoryID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.HasOne(d => d.DelayCategory)
                    .WithOne(p => p.StandardDelayCodeDetail)
                    .HasForeignKey<StandardDelayCodeDetail>(d => d.DelayCategoryId)
                    .HasConstraintName("FK_StdDelayCode_Category");
            });

            modelBuilder.Entity<SupervisorAbsence>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorAbsence", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Who).HasColumnType("ntext");

                entity.Property(e => e.Why).HasColumnType("ntext");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorAbsences)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .HasConstraintName("FK_Absence_ShiftDetail");
            });

            modelBuilder.Entity<SupervisorFieldLeadership>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorFieldLeadership", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeadershipComment).HasColumnType("ntext");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorFieldLeaderships)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .HasConstraintName("FK_FieldLeadership_ShiftDetail");
            });

            modelBuilder.Entity<SupervisorIncidentAccident>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorIncidentAccident", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.Dmsnumber)
                    .HasColumnType("ntext")
                    .HasColumnName("DMSNumber");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorIncidentAccidents)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .HasConstraintName("FK_IncidentAccident_ShiftDetail");
            });

            modelBuilder.Entity<SupervisorMaintenanceNotification>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorMaintenanceNotification", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Jrnumber).HasColumnName("JRNumber");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorMaintenanceNotifications)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .HasConstraintName("FK_MaintenanceNotification_ShiftDetail");
            });

            modelBuilder.Entity<SupervisorShiftDetail>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate });

                entity.ToTable("SupervisorShiftDetail", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Supervisor).HasMaxLength(200);
            });

            modelBuilder.Entity<SupervisorTopIssue>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorTopIssue", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorTopIssues)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .HasConstraintName("FK_TopIssue_ShiftDetail");
            });

            modelBuilder.Entity<SupervisorTraining>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorTraining", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.What).HasColumnType("ntext");

                entity.Property(e => e.Who).HasColumnType("ntext");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorTrainings)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Training_ShiftDetail");
            });

            modelBuilder.Entity<SupervisorUpcomingAction>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.ShiftDate, e.Id });

                entity.ToTable("SupervisorUpcomingAction", "kns");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.SupervisorUpcomingActions)
                    .HasForeignKey(d => new { d.Section, d.ShiftDate })
                    .HasConstraintName("FK_UpcomingAction_ShiftDetail");
            });

            modelBuilder.Entity<TopFloorAdminSetting>(entity =>
            {
                entity.HasKey(e => e.SettingItem)
                    .HasName("PK_FurnaceTopFloorSettings");

                entity.ToTable("TopFloorAdminSettings", "kns");

                entity.Property(e => e.SettingItem).HasMaxLength(50);

                entity.Property(e => e.SerialisedValue).HasColumnType("ntext");

                entity.Property(e => e.SettingType).HasMaxLength(20);
            });

            modelBuilder.Entity<TopFloorBinDip>(entity =>
            {
                entity.HasKey(e => new { e.Bin, e.DipTime });

                entity.ToTable("TopFloorBinDip", "kns");

                entity.Property(e => e.Bin).HasMaxLength(50);

                entity.Property(e => e.DipTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorBinDips)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_TopFloorBinDip_Root");
            });

            modelBuilder.Entity<TopFloorBinDipLookup>(entity =>
            {
                entity.HasKey(e => new { e.Bin, e.DipValue });

                entity.ToTable("TopFloorBinDipLookup", "kns");

                entity.Property(e => e.Bin).HasMaxLength(50);
            });

            modelBuilder.Entity<TopFloorCheck>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.Item })
                    .HasName("PK_kns_Check");

                entity.ToTable("TopFloorCheck", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Item).HasMaxLength(100);

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorChecks)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_kns_TopFloor_Check");
            });

            modelBuilder.Entity<TopFloorCokeRevert>(entity =>
            {
                entity.HasKey(e => new { e.AdditionType, e.ShiftDate });

                entity.ToTable("TopFloorCokeRevert", "kns");

                entity.Property(e => e.AdditionType).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorCokeReverts)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_TopFloorCokeRevert_Root");
            });

            modelBuilder.Entity<TopFloorCokeRevertEntry>(entity =>
            {
                entity.HasKey(e => new { e.AdditionType, e.ShiftDate, e.AdditionVector, e.EntryTime });

                entity.ToTable("TopFloorCokeRevertEntry", "kns");

                entity.Property(e => e.AdditionType).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.AdditionVector).HasMaxLength(50);

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.HasOne(d => d.TopFloorCokeRevert)
                    .WithMany(p => p.TopFloorCokeRevertEntries)
                    .HasForeignKey(d => new { d.AdditionType, d.ShiftDate })
                    .HasConstraintName("FK_TopFloorCokeRevert_Entries");
            });

            modelBuilder.Entity<TopFloorDaySummary>(entity =>
            {
                entity.HasKey(e => e.ReportingDayDate);

                entity.ToTable("TopFloorDaySummary", "kns");

                entity.Property(e => e.ReportingDayDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TopFloorElectrodeManagement>(entity =>
            {
                entity.HasKey(e => e.ShiftDate);

                entity.ToTable("TopFloorElectrodeManagement", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.A1casingCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("A1CasingCompleted");

                entity.Property(e => e.A2casingCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("A2CasingCompleted");

                entity.Property(e => e.A3casingCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("A3CasingCompleted");

                entity.Property(e => e.B1casingCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("B1CasingCompleted");

                entity.Property(e => e.B2casingCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("B2CasingCompleted");

                entity.Property(e => e.B3casingCompleted)
                    .HasColumnType("datetime")
                    .HasColumnName("B3CasingCompleted");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithOne(p => p.TopFloorElectrodeManagement)
                    .HasForeignKey<TopFloorElectrodeManagement>(d => d.ShiftDate)
                    .HasConstraintName("FK_TopFloorElectrodeManagement_Root");
            });

            modelBuilder.Entity<TopFloorElectrodeMeasurement>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.MeasurementTime })
                    .HasName("PK_ElectrodeMeasurement");

                entity.ToTable("TopFloorElectrodeMeasurement", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.MeasurementTime).HasColumnType("datetime");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorElectrodeMeasurements)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_ElectrodeManagement_Measurement");
            });

            modelBuilder.Entity<TopFloorElectrodeMeasurementEntry>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.MeasurementTime, e.Electrode })
                    .HasName("PK_ElectrodeEntry");

                entity.ToTable("TopFloorElectrodeMeasurementEntry", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.MeasurementTime).HasColumnType("datetime");

                entity.Property(e => e.Electrode).HasMaxLength(20);

                entity.Property(e => e.Condition).HasMaxLength(50);

                entity.HasOne(d => d.TopFloorElectrodeMeasurement)
                    .WithMany(p => p.TopFloorElectrodeMeasurementEntries)
                    .HasForeignKey(d => new { d.ShiftDate, d.MeasurementTime })
                    .HasConstraintName("FK_ElectrodeMeasurement_Entry");
            });

            modelBuilder.Entity<TopFloorEquipmentCheck>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.Item })
                    .HasName("PK_kns_EquipmentCheck");

                entity.ToTable("TopFloorEquipmentCheck", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Item).HasMaxLength(100);

                entity.Property(e => e.NotificationNum).HasMaxLength(100);

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorEquipmentChecks)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_kns_TopFloor_Equipment");
            });

            modelBuilder.Entity<TopFloorInspection>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDate, e.CheckType })
                    .HasName("PK_TopFloorCheck");

                entity.ToTable("TopFloorInspection", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.CheckType).HasMaxLength(50);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.ConditionOk).HasColumnName("ConditionOK");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorInspections)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_TopFloorInspection_Root");
            });

            modelBuilder.Entity<TopFloorRoot>(entity =>
            {
                entity.HasKey(e => e.ShiftDate);

                entity.ToTable("TopFloorRoot", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TopFloorShiftReport>(entity =>
            {
                entity.HasKey(e => e.ShiftDate)
                    .HasName("PK_kns_TopFloorShiftReport");

                entity.ToTable("TopFloorShiftReport", "kns");

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.OperatorOff).HasMaxLength(200);

                entity.Property(e => e.OperatorOn).HasMaxLength(200);

                entity.Property(e => e.RevertTotal).HasColumnName("revertTotal");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithOne(p => p.TopFloorShiftReport)
                    .HasForeignKey<TopFloorShiftReport>(d => d.ShiftDate)
                    .HasConstraintName("FK_TopFloorShiftReport_Root");
            });

            modelBuilder.Entity<TopFloorSlagParameter>(entity =>
            {
                entity.HasKey(e => new { e.MeasurementTime, e.Parameter });

                entity.ToTable("TopFloorSlagParameter", "kns");

                entity.Property(e => e.MeasurementTime).HasColumnType("datetime");

                entity.Property(e => e.Parameter).HasMaxLength(20);

                entity.Property(e => e.ShiftDate).HasColumnType("datetime");

                entity.HasOne(d => d.ShiftDateNavigation)
                    .WithMany(p => p.TopFloorSlagParameters)
                    .HasForeignKey(d => d.ShiftDate)
                    .HasConstraintName("FK_TopFloorSlagParameter_Root");
            });

            modelBuilder.Entity<TuyereMeasurement>(entity =>
            {
                entity.HasKey(e => new { e.BlowId, e.BrickNumber })
                    .HasName("PK_BrickCheck");

                entity.ToTable("TuyereMeasurement", "kns");

                entity.Property(e => e.BlowId)
                    .HasMaxLength(50)
                    .HasColumnName("BlowID");

                entity.HasOne(d => d.Blow)
                    .WithMany(p => p.TuyereMeasurements)
                    .HasForeignKey(d => d.BlowId)
                    .HasConstraintName("FK_ConverterCheck_BrickCheck");
            });

            modelBuilder.Entity<ValidationRule>(entity =>
            {
                entity.HasKey(e => new { e.Section, e.FieldId });

                entity.ToTable("ValidationRule", "kns");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.FieldId)
                    .HasMaxLength(200)
                    .HasColumnName("FieldID");

                entity.Property(e => e.RuleType).HasMaxLength(10);
            });

            //modelBuilder.Entity<LoginToken>(entity =>
            //{
            //    entity.HasKey(e => new { e.Id });
            //    entity.ToTable("LoginToken", "kns");
            //});
            modelBuilder.ApplyConfiguration(new LoginTokenConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
