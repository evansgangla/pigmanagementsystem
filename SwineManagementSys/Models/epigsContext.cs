using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SwineManagementSys.Models
{
    public partial class epigsContext : DbContext
    {
        public epigsContext()
        {
        }

        public epigsContext(DbContextOptions<epigsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<AstAccAccount> AstAccAccounts { get; set; } = null!;
        public virtual DbSet<AstAccLedger> AstAccLedgers { get; set; } = null!;
        public virtual DbSet<AstAccPayMode> AstAccPayModes { get; set; } = null!;
        public virtual DbSet<AstAccTranType> AstAccTranTypes { get; set; } = null!;
        public virtual DbSet<AstCullingReason> AstCullingReasons { get; set; } = null!;
        public virtual DbSet<AstHerdAssumption> AstHerdAssumptions { get; set; } = null!;
        public virtual DbSet<AstSetup> AstSetups { get; set; } = null!;
        public virtual DbSet<Masterstockresource> Masterstockresources { get; set; } = null!;
        public virtual DbSet<PmmAccAsset> PmmAccAssets { get; set; } = null!;
        public virtual DbSet<PmmAccBank> PmmAccBanks { get; set; } = null!;
        public virtual DbSet<PmmAccCapital> PmmAccCapitals { get; set; } = null!;
        public virtual DbSet<PmmAccCash> PmmAccCashes { get; set; } = null!;
        public virtual DbSet<PmmAccCostOfSale> PmmAccCostOfSales { get; set; } = null!;
        public virtual DbSet<PmmAccCreditor> PmmAccCreditors { get; set; } = null!;
        public virtual DbSet<PmmAccCurAsset> PmmAccCurAssets { get; set; } = null!;
        public virtual DbSet<PmmAccCurLiability> PmmAccCurLiabilities { get; set; } = null!;
        public virtual DbSet<PmmAccDebtor> PmmAccDebtors { get; set; } = null!;
        public virtual DbSet<PmmAccExpense> PmmAccExpenses { get; set; } = null!;
        public virtual DbSet<PmmAccFixedAsset> PmmAccFixedAssets { get; set; } = null!;
        public virtual DbSet<PmmAccFixedLiability> PmmAccFixedLiabilities { get; set; } = null!;
        public virtual DbSet<PmmAccGl> PmmAccGls { get; set; } = null!;
        public virtual DbSet<PmmAccGlLog> PmmAccGlLogs { get; set; } = null!;
        public virtual DbSet<PmmAccLabourCost> PmmAccLabourCosts { get; set; } = null!;
        public virtual DbSet<PmmAccLiability> PmmAccLiabilities { get; set; } = null!;
        public virtual DbSet<PmmAccMiscIncome> PmmAccMiscIncomes { get; set; } = null!;
        public virtual DbSet<PmmAccProfitLoss> PmmAccProfitLosses { get; set; } = null!;
        public virtual DbSet<PmmAccPurchase> PmmAccPurchases { get; set; } = null!;
        public virtual DbSet<PmmAccSale> PmmAccSales { get; set; } = null!;
        public virtual DbSet<PmmAccStock> PmmAccStocks { get; set; } = null!;
        public virtual DbSet<PmmAccStockValuation> PmmAccStockValuations { get; set; } = null!;
        public virtual DbSet<PmmAccStocksRevalue> PmmAccStocksRevalues { get; set; } = null!;
        public virtual DbSet<PmmAccTrialBalance> PmmAccTrialBalances { get; set; } = null!;
        public virtual DbSet<PmmAccWriteoff> PmmAccWriteoffs { get; set; } = null!;
        public virtual DbSet<PmmActivitiesLog> PmmActivitiesLogs { get; set; } = null!;
        public virtual DbSet<PmmActivity> PmmActivities { get; set; } = null!;
        public virtual DbSet<PmmAlertCategory> PmmAlertCategories { get; set; } = null!;
        public virtual DbSet<PmmAlertLog> PmmAlertLogs { get; set; } = null!;
        public virtual DbSet<PmmAlertsSetup> PmmAlertsSetups { get; set; } = null!;
        public virtual DbSet<PmmBatchDetail> PmmBatchDetails { get; set; } = null!;
        public virtual DbSet<PmmBatchMaster> PmmBatchMasters { get; set; } = null!;
        public virtual DbSet<PmmBreedingCulling> PmmBreedingCullings { get; set; } = null!;
        public virtual DbSet<PmmBreedingPlan> PmmBreedingPlans { get; set; } = null!;
        public virtual DbSet<PmmBreedingPlanDyn> PmmBreedingPlanDyns { get; set; } = null!;
        public virtual DbSet<PmmBreedingSelection> PmmBreedingSelections { get; set; } = null!;
        public virtual DbSet<PmmBusinessDate> PmmBusinessDates { get; set; } = null!;
        public virtual DbSet<PmmCountry> PmmCountries { get; set; } = null!;
        public virtual DbSet<PmmCounty> PmmCounties { get; set; } = null!;
        public virtual DbSet<PmmDepsSummary> PmmDepsSummaries { get; set; } = null!;
        public virtual DbSet<PmmEconomyLog> PmmEconomyLogs { get; set; } = null!;
        public virtual DbSet<PmmFarmresource> PmmFarmresources { get; set; } = null!;
        public virtual DbSet<PmmFarmsMaster> PmmFarmsMasters { get; set; } = null!;
        public virtual DbSet<PmmFeedLog> PmmFeedLogs { get; set; } = null!;
        public virtual DbSet<PmmFeedStock> PmmFeedStocks { get; set; } = null!;
        public virtual DbSet<PmmFeedType> PmmFeedTypes { get; set; } = null!;
        public virtual DbSet<PmmFeedingPlanMaster> PmmFeedingPlanMasters { get; set; } = null!;
        public virtual DbSet<PmmFeedingPlanPd> PmmFeedingPlanPds { get; set; } = null!;
        public virtual DbSet<PmmFeedingPlanPg> PmmFeedingPlanPgs { get; set; } = null!;
        public virtual DbSet<PmmFeedingPlanSlave> PmmFeedingPlanSlaves { get; set; } = null!;
        public virtual DbSet<PmmFeedingRoutine> PmmFeedingRoutines { get; set; } = null!;
        public virtual DbSet<PmmHerdBatchId> PmmHerdBatchIds { get; set; } = null!;
        public virtual DbSet<PmmHerdBreedType> PmmHerdBreedTypes { get; set; } = null!;
        public virtual DbSet<PmmHerdComposition> PmmHerdCompositions { get; set; } = null!;
        public virtual DbSet<PmmHerdValuation> PmmHerdValuations { get; set; } = null!;
        public virtual DbSet<PmmHerdWeight> PmmHerdWeights { get; set; } = null!;
        public virtual DbSet<PmmHerdX> PmmHerdXes { get; set; } = null!;
        public virtual DbSet<PmmHousingPen> PmmHousingPens { get; set; } = null!;
        public virtual DbSet<PmmLogPublisher> PmmLogPublishers { get; set; } = null!;
        public virtual DbSet<PmmReport> PmmReports { get; set; } = null!;
        public virtual DbSet<PmmSalesPlan> PmmSalesPlans { get; set; } = null!;
        public virtual DbSet<PmmSalesTransaction> PmmSalesTransactions { get; set; } = null!;
        public virtual DbSet<PmmSerial> PmmSerials { get; set; } = null!;
        public virtual DbSet<PmmServiceChargeLog> PmmServiceChargeLogs { get; set; } = null!;
        public virtual DbSet<PmmSetup> PmmSetups { get; set; } = null!;
        public virtual DbSet<PmmStandard> PmmStandards { get; set; } = null!;
        public virtual DbSet<PmmStockTakeEntry> PmmStockTakeEntries { get; set; } = null!;
        public virtual DbSet<PmmStockTakeSlave> PmmStockTakeSlaves { get; set; } = null!;
        public virtual DbSet<PmmStockTakeUpdate> PmmStockTakeUpdates { get; set; } = null!;
        public virtual DbSet<PmmStockUpdateLog> PmmStockUpdateLogs { get; set; } = null!;
        public virtual DbSet<PmmStocktakeMst> PmmStocktakeMsts { get; set; } = null!;
        public virtual DbSet<PmmStorageFacility> PmmStorageFacilities { get; set; } = null!;
        public virtual DbSet<PmmSupplier> PmmSuppliers { get; set; } = null!;
        public virtual DbSet<PmmSupplimentDrug> PmmSupplimentDrugs { get; set; } = null!;
        public virtual DbSet<PmmTrialBalance> PmmTrialBalances { get; set; } = null!;
        public virtual DbSet<PmmUser> PmmUsers { get; set; } = null!;
        public virtual DbSet<PmmUserGroup> PmmUserGroups { get; set; } = null!;
        public virtual DbSet<PmmUserGroupRight> PmmUserGroupRights { get; set; } = null!;
        public virtual DbSet<PmmUserModule> PmmUserModules { get; set; } = null!;
        public virtual DbSet<PmmUsers2> PmmUsers2s { get; set; } = null!;
        public virtual DbSet<TmpDepsSummary> TmpDepsSummaries { get; set; } = null!;
        public virtual DbSet<VApplicationSetup> VApplicationSetups { get; set; } = null!;
        public virtual DbSet<VPmmCountry> VPmmCountries { get; set; } = null!;
        public virtual DbSet<ViewCurrentBreedingPlan> ViewCurrentBreedingPlans { get; set; } = null!;
        public virtual DbSet<ViewFeedingPlanRoutine> ViewFeedingPlanRoutines { get; set; } = null!;
        public virtual DbSet<ViewHerdComposition> ViewHerdCompositions { get; set; } = null!;
        public virtual DbSet<ViewSaleOverdue> ViewSaleOverdues { get; set; } = null!;
        public virtual DbSet<ViewSaleTransaction> ViewSaleTransactions { get; set; } = null!;
        public virtual DbSet<ViewStockTakeSheet> ViewStockTakeSheets { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=epigs;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.Farm).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AstAccAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ast_acc_accounts");

                entity.Property(e => e.AccDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("acc_description");

                entity.Property(e => e.AccId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acc_id");

                entity.Property(e => e.AccIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("acc_index");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AstAccLedger>(entity =>
            {
                entity.HasKey(e => e.AccSettingIndex);

                entity.ToTable("ast_acc_ledgers");

                entity.Property(e => e.AccSettingIndex).HasColumnName("acc_setting_index");

                entity.Property(e => e.AccPaymode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acc_paymode");

                entity.Property(e => e.AccTransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acc_transaction_type");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrLedger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cr_ledger");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.DrLedger)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_ledger");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_id");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<AstAccPayMode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ast_acc_pay_modes");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ModeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_id");

                entity.Property(e => e.PayModeIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("pay_mode_index");
            });

            modelBuilder.Entity<AstAccTranType>(entity =>
            {
                entity.HasKey(e => e.TranTypeIndex);

                entity.ToTable("ast_acc_tran_types");

                entity.Property(e => e.TranTypeIndex).HasColumnName("tran_type_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tran_type");

                entity.Property(e => e.TranTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tran_type_id");
            });

            modelBuilder.Entity<AstCullingReason>(entity =>
            {
                entity.HasKey(e => e.CullIndex);

                entity.ToTable("ast_culling_reasons");

                entity.Property(e => e.CullIndex).HasColumnName("cull_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CullReason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cull_reason");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .HasColumnName("farm_id");

                entity.Property(e => e.NoAffected)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("No_affected");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<AstHerdAssumption>(entity =>
            {
                entity.HasKey(e => e.AstHaIndex);

                entity.ToTable("ast_herd_assumptions");

                entity.Property(e => e.AstHaIndex).HasColumnName("ast_ha_index");

                entity.Property(e => e.AstHaActive).HasColumnName("ast_ha_active");

                entity.Property(e => e.AstHaAge)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("ast_ha_age");

                entity.Property(e => e.AstHaAgeFrom)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("ast_ha_age_from");

                entity.Property(e => e.AstHaAgeMetric)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_ha_age_metric");

                entity.Property(e => e.AstHaAgeTo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("ast_ha_age_to");

                entity.Property(e => e.AstHaCycle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_ha_cycle");

                entity.Property(e => e.AstHaFeedMetric)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_ha_feed_metric");

                entity.Property(e => e.AstHaFeedWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("ast_ha_feed_weight");

                entity.Property(e => e.AstHaFeedtype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_ha_feedtype");

                entity.Property(e => e.AstHaSex)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_ha_sex");

                entity.Property(e => e.AstHaWeightFrom)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("ast_ha_weight_from");

                entity.Property(e => e.AstHaWeightMetric)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_ha_weight_metric");

                entity.Property(e => e.AstHaWeightTo)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("ast_ha_weight_to");

                entity.Property(e => e.AstSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ast_sub_group");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<AstSetup>(entity =>
            {
                entity.HasKey(e => e.SetupIndex);

                entity.ToTable("ast_setup");

                entity.Property(e => e.SetupIndex).HasColumnName("setup_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SetupCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_category");

                entity.Property(e => e.SetupDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("setup_description");

                entity.Property(e => e.SetupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_name");

                entity.Property(e => e.SetupValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_value");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<Masterstockresource>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClosingBalance)
                    .HasMaxLength(50)
                    .HasColumnName("closing_balance");

                entity.Property(e => e.DateOfIssue)
                    .HasMaxLength(50)
                    .HasColumnName("date_of_issue");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasColumnName("destination");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .HasColumnName("farm_id");

                entity.Property(e => e.Indx).HasColumnName("indx");

                entity.Property(e => e.IssuePrice)
                    .HasMaxLength(50)
                    .HasColumnName("issue_price");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(50)
                    .HasColumnName("issued_by");

                entity.Property(e => e.Metric)
                    .HasMaxLength(50)
                    .HasColumnName("metric");

                entity.Property(e => e.OpeningBalance)
                    .HasMaxLength(50)
                    .HasColumnName("opening_balance");

                entity.Property(e => e.OriginalStore)
                    .HasMaxLength(50)
                    .HasColumnName("original_store");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .HasColumnName("quantity");

                entity.Property(e => e.ReorderLevel)
                    .HasMaxLength(50)
                    .HasColumnName("reorder_level");

                entity.Property(e => e.ResourceName)
                    .HasMaxLength(50)
                    .HasColumnName("resource_name");

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(50)
                    .HasColumnName("resource_type");
            });

            modelBuilder.Entity<PmmAccAsset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_assets");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_banks");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccCapital>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_capital");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccCash>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_cash");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccCostOfSale>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_cost_of_sale");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccCreditor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_creditors");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccCurAsset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_cur_assets");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccCurLiability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_cur_liabilities");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccDebtor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_debtors");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccExpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_expenses");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccFixedAsset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_fixed_assets");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccFixedLiability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_acc_fixed_liabilities");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.Index)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("index");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccGl>(entity =>
            {
                entity.HasKey(e => e.GlIndex);

                entity.ToTable("pmm_acc_gl");

                entity.Property(e => e.GlIndex).HasColumnName("gl_index");

                entity.Property(e => e.BalanceValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("balance_value");

                entity.Property(e => e.CostPerUnit)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("cost_per_unit");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlDate)
                    .HasColumnType("datetime")
                    .HasColumnName("gl_date");

                entity.Property(e => e.GlDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_description");

                entity.Property(e => e.GlDrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_dr_cr");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlQuantity)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("gl_quantity");

                entity.Property(e => e.GlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_source");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.GlUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_unit");

                entity.Property(e => e.PaidValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("paid_value");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref_no");

                entity.Property(e => e.TotalValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total_value");
            });

            modelBuilder.Entity<PmmAccGlLog>(entity =>
            {
                entity.HasKey(e => e.GlIndex);

                entity.ToTable("pmm_acc_gl_log");

                entity.Property(e => e.GlIndex).HasColumnName("gl_index");

                entity.Property(e => e.BalanceValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("balance_value");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cheque_no");

                entity.Property(e => e.CostPerUnit)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("cost_per_unit");

                entity.Property(e => e.CrAcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cr_acc");

                entity.Property(e => e.DrAcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_acc");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlDate)
                    .HasColumnType("datetime")
                    .HasColumnName("gl_date");

                entity.Property(e => e.GlDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_description");

                entity.Property(e => e.GlDrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_dr_cr");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlQuantity)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("gl_quantity");

                entity.Property(e => e.GlSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_source");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.GlUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_unit");

                entity.Property(e => e.MaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("maturity_date");

                entity.Property(e => e.PaidValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("paid_value");

                entity.Property(e => e.PayMode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pay_mode");

                entity.Property(e => e.PenalRate)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("penal_rate");

                entity.Property(e => e.PostingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("posting_date");

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ref_no");

                entity.Property(e => e.TotalValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total_value");
            });

            modelBuilder.Entity<PmmAccLabourCost>(entity =>
            {
                entity.HasKey(e => e.LabourIndex);

                entity.ToTable("pmm_acc_labour_costs");

                entity.Property(e => e.LabourIndex).HasColumnName("labour_index");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("animal_id");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.LabourDate)
                    .HasColumnType("datetime")
                    .HasColumnName("labour_date");

                entity.Property(e => e.NoOfAnimals)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("no_of_animals");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total_cost");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("unit_cost");
            });

            modelBuilder.Entity<PmmAccLiability>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_liabilities");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccMiscIncome>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_misc_income");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccProfitLoss>(entity =>
            {
                entity.HasKey(e => e.TrialIndex);

                entity.ToTable("pmm_acc_profit_loss");

                entity.Property(e => e.TrialIndex).HasColumnName("trial_index");

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account");

                entity.Property(e => e.AppearanceIndex).HasColumnName("appearance_index");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<PmmAccPurchase>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_purchases");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccSale>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_sales");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccStock>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_stocks");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccStockValuation>(entity =>
            {
                entity.HasKey(e => e.StockIndex);

                entity.ToTable("pmm_acc_stock_valuation");

                entity.Property(e => e.StockIndex).HasColumnName("stock_index");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("animal_id");

                entity.Property(e => e.Entry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entry");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("quantity");

                entity.Property(e => e.TotalValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total_value");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("unit_price");

                entity.Property(e => e.Units)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("units");
            });

            modelBuilder.Entity<PmmAccStocksRevalue>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_stocks_revalue");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmAccTrialBalance>(entity =>
            {
                entity.HasKey(e => e.TrialIndex);

                entity.ToTable("pmm_acc_trial_balance");

                entity.Property(e => e.TrialIndex).HasColumnName("trial_index");

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account");

                entity.Property(e => e.CrAmount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("cr_amount");

                entity.Property(e => e.DrAmount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("dr_amount");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");
            });

            modelBuilder.Entity<PmmAccWriteoff>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_acc_writeoff");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("amount");

                entity.Property(e => e.ClosingBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("closing_bal");

                entity.Property(e => e.ClosingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("closing_date");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("details");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("dr_cr");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.GlItem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_item");

                entity.Property(e => e.GlRefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_ref_no");

                entity.Property(e => e.GlTranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_tran_type");

                entity.Property(e => e.OpeningBal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("opening_bal");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");
            });

            modelBuilder.Entity<PmmActivitiesLog>(entity =>
            {
                entity.HasKey(e => e.ActIndex);

                entity.ToTable("pmm_activities_log");

                entity.Property(e => e.ActIndex).HasColumnName("act_index");

                entity.Property(e => e.ActCostPerUnit)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("act_cost_per_unit");

                entity.Property(e => e.ActDate)
                    .HasColumnType("datetime")
                    .HasColumnName("act_date");

                entity.Property(e => e.ActDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("act_description");

                entity.Property(e => e.ActName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("act_name");

                entity.Property(e => e.ActQuantity)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("act_quantity");

                entity.Property(e => e.ActReference)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("act_reference");

                entity.Property(e => e.ActType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("act_type");

                entity.Property(e => e.ActValue)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("act_value");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.GlUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_unit");
            });

            modelBuilder.Entity<PmmActivity>(entity =>
            {
                entity.HasKey(e => e.ActIndex);

                entity.ToTable("pmm_activities");

                entity.Property(e => e.ActIndex).HasColumnName("act_index");

                entity.Property(e => e.ActActive).HasColumnName("act_active");

                entity.Property(e => e.ActDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("act_description");

                entity.Property(e => e.ActName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("act_name");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmAlertCategory>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_alert_categories");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<PmmAlertLog>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("pmm_alert_log");

                entity.Property(e => e.Index).HasColumnName("index");

                entity.Property(e => e.AlertDate)
                    .HasColumnType("datetime")
                    .HasColumnName("alert_date");

                entity.Property(e => e.AlertId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("alert_id");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.Message)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("module_id");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<PmmAlertsSetup>(entity =>
            {
                entity.HasKey(e => e.AlertSetupIndex);

                entity.ToTable("pmm_alerts_setup");

                entity.Property(e => e.AlertSetupIndex).HasColumnName("alert_setup_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.FrequencyDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frequency_duration");

                entity.Property(e => e.FrequencyFigure)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("frequency_figure");

                entity.Property(e => e.Message)
                    .IsUnicode(false)
                    .HasColumnName("message");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");

                entity.Property(e => e.ThresholdDuration)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("threshold_duration");

                entity.Property(e => e.ThresholdFigure)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("threshold_figure");
            });

            modelBuilder.Entity<PmmBatchDetail>(entity =>
            {
                entity.HasKey(e => e.BatchDetailIndex);

                entity.ToTable("pmm_batch_details");

                entity.Property(e => e.BatchDetailIndex).HasColumnName("batch_detail_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_id");

                entity.Property(e => e.BatchParentBoar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_parent_boar");

                entity.Property(e => e.BatchParentSow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_parent_sow");

                entity.Property(e => e.BatchingAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batching_animal_id");

                entity.Property(e => e.BatchingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("batching_date");

                entity.Property(e => e.BatchingDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("batching_date_born");

                entity.Property(e => e.BatchingGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batching_group");

                entity.Property(e => e.BatchingGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("batching_group_no");

                entity.Property(e => e.BatchingGroupWeight)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("batching_group_weight");

                entity.Property(e => e.BreedType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("breed_type");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmBatchMaster>(entity =>
            {
                entity.HasKey(e => e.BatchIndex);

                entity.ToTable("pmm_batch_master");

                entity.Property(e => e.BatchIndex).HasColumnName("batch_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batch_id");

                entity.Property(e => e.BatchMaxDob)
                    .HasColumnType("datetime")
                    .HasColumnName("batch_max_dob");

                entity.Property(e => e.BatchMinDob)
                    .HasColumnType("datetime")
                    .HasColumnName("batch_min_dob");

                entity.Property(e => e.BatchingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("batching_date");

                entity.Property(e => e.BatchingGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("batching_group");

                entity.Property(e => e.BatchingGroupNo)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("batching_group_no");

                entity.Property(e => e.BatchingWeight)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("batching_weight");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmBreedingCulling>(entity =>
            {
                entity.HasKey(e => e.BcIndex);

                entity.ToTable("pmm_breeding_culling");

                entity.Property(e => e.BcIndex).HasColumnName("bc_index");

                entity.Property(e => e.BcAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bc_animal_id");

                entity.Property(e => e.BcCullType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bc_cull_type");

                entity.Property(e => e.BcDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bc_date");

                entity.Property(e => e.BcGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bc_group");

                entity.Property(e => e.BcGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bc_group_no");

                entity.Property(e => e.BcReasons)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bc_reasons");

                entity.Property(e => e.BcReferenceNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("bc_reference_no")
                    .HasComputedColumnSql("(CONVERT([varchar](10),[bc_index],(0))+[bc_animal_id])", false);

                entity.Property(e => e.BcSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bc_source");

                entity.Property(e => e.BcSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bc_sub_group");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmBreedingPlan>(entity =>
            {
                entity.HasKey(e => e.BpIndex);

                entity.ToTable("pmm_breeding_plan");

                entity.Property(e => e.BpIndex).HasColumnName("bp_index");

                entity.Property(e => e.BpBatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_batchID");

                entity.Property(e => e.BpBoarId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_boarID");

                entity.Property(e => e.BpBreedingTicket).HasColumnName("bp_breeding_ticket");

                entity.Property(e => e.BpConceptionRate).HasColumnName("bp_conception_rate");

                entity.Property(e => e.BpCurBorn)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_born");

                entity.Property(e => e.BpCurDeadPost)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_dead_post");

                entity.Property(e => e.BpCurDeadPre)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_dead_pre");

                entity.Property(e => e.BpCurKiddlingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_cur_kiddling_dt");

                entity.Property(e => e.BpCurPostweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_cur_postwean_mort");

                entity.Property(e => e.BpCurPreweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_cur_prewean_mort");

                entity.Property(e => e.BpCurServingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_cur_serving_dt");

                entity.Property(e => e.BpCurWeaned)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_weaned");

                entity.Property(e => e.BpCurWeaningDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_cur_weaning_dt");

                entity.Property(e => e.BpCycleIndex).HasColumnName("bp_cycle_index");

                entity.Property(e => e.BpDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_date_born");

                entity.Property(e => e.BpExpBorn)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_exp_born");

                entity.Property(e => e.BpExpDeadPost)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_dead_post");

                entity.Property(e => e.BpExpDeadPre)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_dead_pre");

                entity.Property(e => e.BpExpKiddlingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_kiddling_dt");

                entity.Property(e => e.BpExpPostweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_postwean_mort");

                entity.Property(e => e.BpExpPreweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_prewean_mort");

                entity.Property(e => e.BpExpServingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_serving_dt");

                entity.Property(e => e.BpExpWeaned)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_exp_weaned");

                entity.Property(e => e.BpExpWeaningDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_weaning_dt");

                entity.Property(e => e.BpFarrowDt).HasColumnName("bp_farrow_dt");

                entity.Property(e => e.BpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_group");

                entity.Property(e => e.BpKiddlingWt)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_Kiddling_Wt");

                entity.Property(e => e.BpLitterId).HasColumnName("bp_litter_id");

                entity.Property(e => e.BpLitterMass).HasColumnName("bp_litter_mass");

                entity.Property(e => e.BpPregnancyTest).HasColumnName("bp_pregnancy_test");

                entity.Property(e => e.BpPregnancyTicket).HasColumnName("bp_pregnancy_ticket");

                entity.Property(e => e.BpReturnsRate).HasColumnName("bp_returns_rate");

                entity.Property(e => e.BpSowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_sowID");

                entity.Property(e => e.BpStatus).HasColumnName("bp_status");

                entity.Property(e => e.BpSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_sub_group");

                entity.Property(e => e.BpWeanersWt)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_weaners_Wt");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmBreedingPlanDyn>(entity =>
            {
                entity.HasKey(e => e.BpIndex);

                entity.ToTable("pmm_breeding_plan_dyn");

                entity.Property(e => e.BpIndex).HasColumnName("bp_index");

                entity.Property(e => e.BpBatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_batchID");

                entity.Property(e => e.BpBoarId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_boarID");

                entity.Property(e => e.BpCurBorn)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_born");

                entity.Property(e => e.BpCurDeadPost)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_dead_post");

                entity.Property(e => e.BpCurDeadPre)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_dead_pre");

                entity.Property(e => e.BpCurKiddlingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_cur_kiddling_dt");

                entity.Property(e => e.BpCurPostweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_cur_postwean_mort");

                entity.Property(e => e.BpCurPreweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_cur_prewean_mort");

                entity.Property(e => e.BpCurServingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_cur_serving_dt");

                entity.Property(e => e.BpCurWeaned)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_cur_weaned");

                entity.Property(e => e.BpCurWeaningDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_cur_weaning_dt");

                entity.Property(e => e.BpCycleIndex).HasColumnName("bp_cycle_index");

                entity.Property(e => e.BpDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_date_born");

                entity.Property(e => e.BpExpBorn)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_exp_born");

                entity.Property(e => e.BpExpDeadPost)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_dead_post");

                entity.Property(e => e.BpExpDeadPre)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_dead_pre");

                entity.Property(e => e.BpExpKiddlingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_kiddling_dt");

                entity.Property(e => e.BpExpPostweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_postwean_mort");

                entity.Property(e => e.BpExpPreweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_prewean_mort");

                entity.Property(e => e.BpExpServingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_serving_dt");

                entity.Property(e => e.BpExpWeaned)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_exp_weaned");

                entity.Property(e => e.BpExpWeaningDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_weaning_dt");

                entity.Property(e => e.BpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_group");

                entity.Property(e => e.BpKiddlingWt)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_Kiddling_Wt");

                entity.Property(e => e.BpSowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_sowID");

                entity.Property(e => e.BpStatus).HasColumnName("bp_status");

                entity.Property(e => e.BpSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_sub_group");

                entity.Property(e => e.BpWeanersWt)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_weaners_Wt");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmBreedingSelection>(entity =>
            {
                entity.HasKey(e => e.BsIndex);

                entity.ToTable("pmm_breeding_selection");

                entity.Property(e => e.BsIndex).HasColumnName("bs_index");

                entity.Property(e => e.BsAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bs_animal_id");

                entity.Property(e => e.BsAnimalSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bs_animal_source");

                entity.Property(e => e.BsGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bs_group");

                entity.Property(e => e.BsGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bs_group_no");

                entity.Property(e => e.BsSelectionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bs_selection_date");

                entity.Property(e => e.BsSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bs_sub_group");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmBusinessDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_business_dates");

                entity.Property(e => e.BusinessDateSysDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Business_Date_SysDate");

                entity.Property(e => e.CurBusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cur_Business_Date");

                entity.Property(e => e.DateIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("date_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_id");

                entity.Property(e => e.PrevBusinessDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Prev_Business_Date");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("pmm_countries");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CountryIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("country_index");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_name");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmCounty>(entity =>
            {
                entity.HasKey(e => e.CountyId);

                entity.ToTable("pmm_counties");

                entity.Property(e => e.CountyId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("county_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CountyIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("county_index");

                entity.Property(e => e.CountyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("County_name");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmDepsSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_deps_summary");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.FpAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_animal_id");

                entity.Property(e => e.FpCycleNo).HasColumnName("fp_cycle_no");

                entity.Property(e => e.FpDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_born");

                entity.Property(e => e.FpDepsNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_deps_no");

                entity.Property(e => e.FpIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fp_index");
            });

            modelBuilder.Entity<PmmEconomyLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_economy_log");

                entity.Property(e => e.ElActive).HasColumnName("el_active");

                entity.Property(e => e.ElDate)
                    .HasColumnType("datetime")
                    .HasColumnName("el_date");

                entity.Property(e => e.ElDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("el_description");

                entity.Property(e => e.ElIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("el_index");

                entity.Property(e => e.ElQuantity)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("el_quantity");

                entity.Property(e => e.ElReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("el_reference_no");

                entity.Property(e => e.ElSourceModule)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("el_source_module");

                entity.Property(e => e.ElUnitCost)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("el_unit_cost");

                entity.Property(e => e.ElValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("el_value");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");
            });

            modelBuilder.Entity<PmmFarmresource>(entity =>
            {
                entity.HasKey(e => e.FrIndex);

                entity.ToTable("pmm_farmresources");

                entity.Property(e => e.FrIndex).HasColumnName("fr_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FrActive).HasColumnName("fr_active");

                entity.Property(e => e.FrComment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_comment");

                entity.Property(e => e.FrDate)
                    .HasColumnType("date")
                    .HasColumnName("fr_date");

                entity.Property(e => e.FrGrnnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_grnnumber");

                entity.Property(e => e.FrMetric)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_metric");

                entity.Property(e => e.FrName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fr_name");

                entity.Property(e => e.FrQuantity)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_quantity");

                entity.Property(e => e.FrSupplier)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_supplier");

                entity.Property(e => e.FrTotalCost)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_total_cost");

                entity.Property(e => e.FrTotalcost1)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("fr_totalcost");

                entity.Property(e => e.FrType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fr_type");

                entity.Property(e => e.FrUnitcost)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_unitcost");

                entity.Property(e => e.Reorder)
                    .HasMaxLength(50)
                    .HasColumnName("reorder");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(50)
                    .HasColumnName("store_id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmFarmsMaster>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("pmm_farms_Master");

                entity.Property(e => e.UniqueId)
                    .ValueGeneratedNever()
                    .HasColumnName("UniqueID");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_on");

                entity.Property(e => e.FarmActive).HasColumnName("Farm_Active");

                entity.Property(e => e.FarmAddress)
                    .IsUnicode(false)
                    .HasColumnName("Farm_address");

                entity.Property(e => e.FarmContactPerson)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Contact_person");

                entity.Property(e => e.FarmCountry)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Country");

                entity.Property(e => e.FarmCounty)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmEmail)
                    .IsUnicode(false)
                    .HasColumnName("Farm_email");

                entity.Property(e => e.FarmId)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Farm_index");

                entity.Property(e => e.FarmLocation)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Location");

                entity.Property(e => e.FarmName)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.FarmStore).IsUnicode(false);

                entity.Property(e => e.FarmTelephone)
                    .IsUnicode(false)
                    .HasColumnName("Farm_telephone");

                entity.Property(e => e.FarmTown)
                    .IsUnicode(false)
                    .HasColumnName("Farm_town");

                entity.Property(e => e.GeoTag).IsUnicode(false);

                entity.Property(e => e.MainFarmId)
                    .IsUnicode(false)
                    .HasColumnName("Main_FarmID");

                entity.Property(e => e.ManagerAlternateEmail).IsUnicode(false);

                entity.Property(e => e.ManagerEmailAddress).IsUnicode(false);

                entity.Property(e => e.ManagerFirstName).IsUnicode(false);

                entity.Property(e => e.ManagerLastName).IsUnicode(false);

                entity.Property(e => e.ManagerMiddleName).IsUnicode(false);

                entity.Property(e => e.ManagerPhoneNumber).IsUnicode(false);

                entity.Property(e => e.Size).IsUnicode(false);

                entity.Property(e => e.SvcStatus)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");

                entity.Property(e => e.TatooLength).IsUnicode(false);

                entity.Property(e => e.TatooPrefix).IsUnicode(false);

                entity.Property(e => e.UoM).IsUnicode(false);
            });

            modelBuilder.Entity<PmmFeedLog>(entity =>
            {
                entity.HasKey(e => e.StIndex);

                entity.ToTable("pmm_feed_log");

                entity.Property(e => e.StIndex).HasColumnName("st_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.StCostPerKg)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cost_per_kg");

                entity.Property(e => e.StDate)
                    .HasColumnType("datetime")
                    .HasColumnName("st_date");

                entity.Property(e => e.StFeedName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_feed_name");

                entity.Property(e => e.StFeedType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_feed_type");

                entity.Property(e => e.StQuantity)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_quantity");

                entity.Property(e => e.StReason)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("st_reason");

                entity.Property(e => e.StReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_reference_no");

                entity.Property(e => e.StTranSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_tran_source");

                entity.Property(e => e.StUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_unit");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmFeedStock>(entity =>
            {
                entity.HasKey(e => e.FsIndex);

                entity.ToTable("pmm_feed_stock");

                entity.Property(e => e.FsIndex).HasColumnName("fs_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(10)
                    .HasColumnName("Farm_Id")
                    .IsFixedLength();

                entity.Property(e => e.FsCostPerKg)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fs_cost_per_kg");

                entity.Property(e => e.FsCurrentStock)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fs_current_stock");

                entity.Property(e => e.FsDeficitStock)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fs_deficit_stock");

                entity.Property(e => e.FsFeedName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fs_feed_name");

                entity.Property(e => e.FsFeedType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fs_feed_type");

                entity.Property(e => e.FsMinimumStock)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fs_minimum_stock");

                entity.Property(e => e.FsUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fs_unit");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmFeedType>(entity =>
            {
                entity.HasKey(e => e.FbIndex);

                entity.ToTable("pmm_feed_types");

                entity.Property(e => e.FbIndex).HasColumnName("fb_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FbActive).HasColumnName("fb_active");

                entity.Property(e => e.FbCost)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("fb_cost");

                entity.Property(e => e.FbCostPerKg)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fb_cost_per_kg");

                entity.Property(e => e.FbName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fb_name");

                entity.Property(e => e.FbType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fb_type");

                entity.Property(e => e.FbWeight)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fb_weight");

                entity.Property(e => e.FbWtUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fb_wt_unit");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmFeedingPlanMaster>(entity =>
            {
                entity.HasKey(e => e.FpIndex);

                entity.ToTable("pmm_feeding_plan_master");

                entity.Property(e => e.FpIndex).HasColumnName("fp_index");

                entity.Property(e => e.FpActive).HasColumnName("fp_active");

                entity.Property(e => e.FpAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_animal_id");

                entity.Property(e => e.FpConcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_conc_name");

                entity.Property(e => e.FpDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_born");

                entity.Property(e => e.FpDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_from");

                entity.Property(e => e.FpDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_to");

                entity.Property(e => e.FpDepsConcCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_conc_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsConcWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_conc_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsDays)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_deps_days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsFodCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_fod_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsFodWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_fod_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_deps_no")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpDepsRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpExpAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_exp_act");

                entity.Property(e => e.FpFarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_farm_id");

                entity.Property(e => e.FpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_group");

                entity.Property(e => e.FpGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_group_no")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalConcCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_conc_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalConcWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_conc_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalDays)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_normal_days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalFodCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_fod_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalFodWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_fod_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPreganantRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_preganant_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnantConcCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_pregnant_conc_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnantConcWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_pregnant_conc_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnantCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_pregnant_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnantDays)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_pregnant_days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnantFodCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_pregnant_fod_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnantFodWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_pregnant_fod_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalConcCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_total_conc_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalConcWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_total_conc_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_total_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalFodCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_total_fod_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalFodWt)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_total_fod_wt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_total_ration")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PmmFeedingPlanPd>(entity =>
            {
                entity.HasKey(e => e.PdIndex);

                entity.ToTable("pmm_feeding_plan_pd");

                entity.Property(e => e.PdIndex).HasColumnName("pd_index");

                entity.Property(e => e.PdActive).HasColumnName("pd_active");

                entity.Property(e => e.PdAge).HasColumnName("pd_age");

                entity.Property(e => e.PdCycleIndex).HasColumnName("pd_cycle_index");

                entity.Property(e => e.PdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pd_date");

                entity.Property(e => e.PdDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("pd_date_born");

                entity.Property(e => e.PdDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("pd_date_from");

                entity.Property(e => e.PdDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("pd_date_to");

                entity.Property(e => e.PdDepRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("pd_dep_ration");

                entity.Property(e => e.PdDeps).HasColumnName("pd_deps");

                entity.Property(e => e.PdDepsTotalRation)
                    .HasColumnType("decimal(26, 4)")
                    .HasColumnName("pd_deps_total_ration")
                    .HasComputedColumnSql("([pd_deps]*[pd_dep_ration])", false);

                entity.Property(e => e.PdExpAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pd_exp_act");

                entity.Property(e => e.PdFarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pd_farm_id");

                entity.Property(e => e.PdSowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pd_sow_id");
            });

            modelBuilder.Entity<PmmFeedingPlanPg>(entity =>
            {
                entity.HasKey(e => e.PgIndex);

                entity.ToTable("pmm_feeding_plan_pg");

                entity.Property(e => e.PgIndex).HasColumnName("pg_index");

                entity.Property(e => e.PgActive).HasColumnName("pg_active");

                entity.Property(e => e.PgAge).HasColumnName("pg_age");

                entity.Property(e => e.PgCycleIndex).HasColumnName("pg_cycle_index");

                entity.Property(e => e.PgDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pg_date");

                entity.Property(e => e.PgDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("pg_date_born");

                entity.Property(e => e.PgDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("pg_date_from");

                entity.Property(e => e.PgDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("pg_date_to");

                entity.Property(e => e.PgExpAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pg_exp_act");

                entity.Property(e => e.PgFarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pg_farm_id");

                entity.Property(e => e.PgRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("pg_ration");

                entity.Property(e => e.PgSowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pg_sow_id");
            });

            modelBuilder.Entity<PmmFeedingPlanSlave>(entity =>
            {
                entity.HasKey(e => e.FpIndex)
                    .IsClustered(false);

                entity.ToTable("pmm_feeding_plan_slave");

                entity.HasIndex(e => e.FpFarmId, "_dta_index_pmm_feeding_plan_slave_5_532196946__K53");

                entity.HasIndex(e => new { e.FpFarmId, e.FpAnimalId, e.FpDate }, "_dta_index_pmm_feeding_plan_slave_5_532196946__K53_K2_K6");

                entity.HasIndex(e => e.FpAnimalId, "_dta_index_pmm_feeding_plan_slave_c_5_532196946__K2")
                    .IsClustered();

                entity.Property(e => e.FpIndex).HasColumnName("fp_index");

                entity.Property(e => e.FpActive).HasColumnName("fp_active");

                entity.Property(e => e.FpAge)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_age");

                entity.Property(e => e.FpAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_animal_id");

                entity.Property(e => e.FpConcCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_conc_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpConcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_conc_name");

                entity.Property(e => e.FpConcPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fp_conc_per");

                entity.Property(e => e.FpCycleNo).HasColumnName("fp_cycle_no");

                entity.Property(e => e.FpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date");

                entity.Property(e => e.FpDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_born");

                entity.Property(e => e.FpDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_from");

                entity.Property(e => e.FpDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_date_to");

                entity.Property(e => e.FpDepsConcCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_deps_conc_cost")
                    .HasComputedColumnSql("([fp_conc_cost]*(([fp_conc_per]*[fp_deps_ration])/(100)))", false);

                entity.Property(e => e.FpDepsConcWt)
                    .HasColumnType("decimal(35, 10)")
                    .HasColumnName("fp_deps_conc_wt")
                    .HasComputedColumnSql("(([fp_conc_per]*[fp_deps_ration])/(100))", false);

                entity.Property(e => e.FpDepsCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_deps_cost")
                    .HasComputedColumnSql("([fp_conc_cost]*(([fp_conc_per]*[fp_deps_ration])/(100))+[fp_fod_cost]*([fp_deps_ration]-([fp_conc_per]*[fp_deps_ration])/(100)))", false);

                entity.Property(e => e.FpDepsDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_deps_date_from");

                entity.Property(e => e.FpDepsDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_deps_date_to");

                entity.Property(e => e.FpDepsExpAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_deps_exp_act");

                entity.Property(e => e.FpDepsFodCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_deps_fod_cost")
                    .HasComputedColumnSql("([fp_fod_cost]*([fp_deps_ration]-([fp_conc_per]*[fp_deps_ration])/(100)))", false);

                entity.Property(e => e.FpDepsFodWt)
                    .HasColumnType("decimal(36, 10)")
                    .HasColumnName("fp_deps_fod_wt")
                    .HasComputedColumnSql("([fp_deps_ration]-([fp_conc_per]*[fp_deps_ration])/(100))", false);

                entity.Property(e => e.FpDepsNo).HasColumnName("fp_deps_no");

                entity.Property(e => e.FpDepsRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_deps_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpExpAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_exp_act");

                entity.Property(e => e.FpFarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_farm_id");

                entity.Property(e => e.FpFodCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_fod_cost")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpFodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_fod_name");

                entity.Property(e => e.FpFodPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fp_fod_per");

                entity.Property(e => e.FpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_group");

                entity.Property(e => e.FpGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fp_group_no")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpNormalConcCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_normal_conc_cost")
                    .HasComputedColumnSql("((([fp_conc_cost]*[fp_conc_per])*[fp_normal_ration])/(100))", false);

                entity.Property(e => e.FpNormalConcWt)
                    .HasColumnType("decimal(35, 10)")
                    .HasColumnName("fp_normal_conc_wt")
                    .HasComputedColumnSql("(([fp_conc_per]*[fp_normal_ration])/(100))", false);

                entity.Property(e => e.FpNormalCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_normal_cost")
                    .HasComputedColumnSql("((([fp_conc_cost]*[fp_conc_per])*[fp_normal_ration])/(100)+[fp_fod_cost]*([fp_normal_ration]-([fp_conc_per]*[fp_normal_ration])/(100)))", false);

                entity.Property(e => e.FpNormalDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_normal_date_from");

                entity.Property(e => e.FpNormalDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_normal_date_to");

                entity.Property(e => e.FpNormalFodCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_normal_fod_cost")
                    .HasComputedColumnSql("([fp_fod_cost]*([fp_normal_ration]-([fp_conc_per]*[fp_normal_ration])/(100)))", false);

                entity.Property(e => e.FpNormalFodWt)
                    .HasColumnType("decimal(36, 10)")
                    .HasColumnName("fp_normal_fod_wt")
                    .HasComputedColumnSql("([fp_normal_ration]-([fp_conc_per]*[fp_normal_ration])/(100))", false);

                entity.Property(e => e.FpNormalRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_normal_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpPregnanctFodCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_pregnanct_fod_cost")
                    .HasComputedColumnSql("(([fp_pregnant_ration]-([fp_conc_per]*[fp_pregnant_ration])/(100))*[fp_fod_cost])", false);

                entity.Property(e => e.FpPregnantConcCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_pregnant_conc_cost")
                    .HasComputedColumnSql("((([fp_conc_per]*[fp_pregnant_ration])/(100))*[fp_conc_cost])", false);

                entity.Property(e => e.FpPregnantConcWt)
                    .HasColumnType("decimal(35, 10)")
                    .HasColumnName("fp_pregnant_conc_wt")
                    .HasComputedColumnSql("(([fp_conc_per]*[fp_pregnant_ration])/(100))", false);

                entity.Property(e => e.FpPregnantCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_pregnant_cost")
                    .HasComputedColumnSql("((([fp_conc_per]*[fp_pregnant_ration])/(100))*[fp_conc_cost]+([fp_pregnant_ration]-([fp_conc_per]*[fp_pregnant_ration])/(100))*[fp_fod_cost])", false);

                entity.Property(e => e.FpPregnantDateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_pregnant_date_from");

                entity.Property(e => e.FpPregnantDateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("fp_pregnant_date_to");

                entity.Property(e => e.FpPregnantExpAct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_pregnant_exp_act");

                entity.Property(e => e.FpPregnantFodWt)
                    .HasColumnType("decimal(36, 10)")
                    .HasColumnName("fp_pregnant_fod_wt")
                    .HasComputedColumnSql("([fp_pregnant_ration]-([fp_conc_per]*[fp_pregnant_ration])/(100))", false);

                entity.Property(e => e.FpPregnantRation)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("fp_pregnant_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FpTotalConcCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_total_conc_cost")
                    .HasComputedColumnSql("([fp_conc_cost]*(((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])*[fp_conc_per])/(100)))", false);

                entity.Property(e => e.FpTotalConcWt)
                    .HasColumnType("decimal(37, 10)")
                    .HasColumnName("fp_total_conc_wt")
                    .HasComputedColumnSql("(((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])*[fp_conc_per])/(100))", false);

                entity.Property(e => e.FpTotalCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_total_cost")
                    .HasComputedColumnSql("([fp_conc_cost]*(((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])*[fp_conc_per])/(100))+[fp_fod_cost]*((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])-((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])*[fp_conc_per])/(100)))", false);

                entity.Property(e => e.FpTotalFodCost)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("fp_total_fod_cost")
                    .HasComputedColumnSql("([fp_fod_cost]*((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])-((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])*[fp_conc_per])/(100)))", false);

                entity.Property(e => e.FpTotalFodWt)
                    .HasColumnType("decimal(38, 10)")
                    .HasColumnName("fp_total_fod_wt")
                    .HasComputedColumnSql("((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])-((([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])*[fp_conc_per])/(100))", false);

                entity.Property(e => e.FpTotalRation)
                    .HasColumnType("decimal(17, 4)")
                    .HasColumnName("fp_total_ration")
                    .HasComputedColumnSql("(([fp_pregnant_ration]+[fp_deps_ration])+[fp_normal_ration])", false);

                entity.Property(e => e.FpWeekFrom).HasColumnName("fp_week_from");

                entity.Property(e => e.FpWeekTo).HasColumnName("fp_week_to");
            });

            modelBuilder.Entity<PmmFeedingRoutine>(entity =>
            {
                entity.HasKey(e => e.FrIndex);

                entity.ToTable("pmm_feeding_routine");

                entity.Property(e => e.FrIndex).HasColumnName("fr_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FrActive).HasColumnName("fr_active");

                entity.Property(e => e.FrAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_animal_id");

                entity.Property(e => e.FrConcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_conc_name");

                entity.Property(e => e.FrConcPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_conc_per");

                entity.Property(e => e.FrConcWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_conc_weight");

                entity.Property(e => e.FrCurAge)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_cur_age");

                entity.Property(e => e.FrCurConcPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_cur_conc_per");

                entity.Property(e => e.FrCurDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fr_cur_date");

                entity.Property(e => e.FrCurFodPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_cur_fod_per");

                entity.Property(e => e.FrCurPer)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("fr_cur_per")
                    .HasComputedColumnSql("([fr_cur_conc_per]+[fr_cur_fod_per])", false);

                entity.Property(e => e.FrCurRation)
                    .HasColumnType("decimal(16, 2)")
                    .HasColumnName("fr_cur_ration")
                    .HasComputedColumnSql("([fr_conc_weight]+[fr_fod_weight])", false);

                entity.Property(e => e.FrCurWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_cur_weight");

                entity.Property(e => e.FrCycle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_cycle");

                entity.Property(e => e.FrDailyRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_daily_ration");

                entity.Property(e => e.FrDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("fr_date_born");

                entity.Property(e => e.FrDependantsNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_dependants_no");

                entity.Property(e => e.FrExpDailyRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_exp_daily_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FrExpDepDailyRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_exp_dep_daily_ration")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FrExpTotalRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_exp_total_ration");

                entity.Property(e => e.FrFodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_fod_name");

                entity.Property(e => e.FrFodPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_fod_per");

                entity.Property(e => e.FrFodWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_fod_weight");

                entity.Property(e => e.FrGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_group");

                entity.Property(e => e.FrGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_group_no");

                entity.Property(e => e.FrSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_sub_group");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmHerdBatchId>(entity =>
            {
                entity.HasKey(e => e.Idx)
                    .HasName("PK_pmm_herdbatchid");

                entity.ToTable("pmm_herd_batch_id");

                entity.Property(e => e.AnimalBatchId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("animal_batch_id");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmHerdBreedType>(entity =>
            {
                entity.HasKey(e => e.BreedIndex);

                entity.ToTable("pmm_herd_breed_types");

                entity.Property(e => e.BreedIndex).HasColumnName("breed_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.BreedDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("breed_description");

                entity.Property(e => e.BreedImage).HasColumnName("breed_image");

                entity.Property(e => e.BreedName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("breed_name");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .HasColumnName("farm_id");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmHerdComposition>(entity =>
            {
                entity.HasKey(e => e.HcIndex);

                entity.ToTable("pmm_herd_composition");

                entity.Property(e => e.HcIndex).HasColumnName("hc_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.HcActive).HasColumnName("hc_active");

                entity.Property(e => e.HcAge)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_age");

                entity.Property(e => e.HcAgeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_age_unit");

                entity.Property(e => e.HcAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_animal_id");

                entity.Property(e => e.HcBreedType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_breed_type");

                entity.Property(e => e.HcCycle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_cycle");

                entity.Property(e => e.HcDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("hc_date_born");

                entity.Property(e => e.HcDateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("hc_date_created");

                entity.Property(e => e.HcFarrowdate).HasColumnName("hc_farrowdate");

                entity.Property(e => e.HcGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_group");

                entity.Property(e => e.HcGroupBought)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_group_bought");

                entity.Property(e => e.HcGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_group_no");

                entity.Property(e => e.HcGroupOpeningStock)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_group_opening_stock");

                entity.Property(e => e.HcGroupValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_group_value");

                entity.Property(e => e.HcOpenningStock)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_openning_stock");

                entity.Property(e => e.HcParentBoar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_parent_boar");

                entity.Property(e => e.HcParentSow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_parent_sow");

                entity.Property(e => e.HcPen).HasColumnName("hc_pen");

                entity.Property(e => e.HcServingdate)
                    .HasMaxLength(50)
                    .HasColumnName("hc_servingdate");

                entity.Property(e => e.HcSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_source");

                entity.Property(e => e.HcSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_sub_group");

                entity.Property(e => e.HcUnitCost)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_unit_cost");

                entity.Property(e => e.HcWeandate).HasColumnName("hc_weandate");

                entity.Property(e => e.HcWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_weight");

                entity.Property(e => e.HcWeightUnits)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_weight_units");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmHerdValuation>(entity =>
            {
                entity.HasKey(e => e.HvIndex);

                entity.ToTable("pmm_herd_valuation");

                entity.Property(e => e.HvIndex).HasColumnName("hv_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.HvDressedCostPerKg)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hv_dressed_cost_perKg");

                entity.Property(e => e.HvDressingPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hv_dressing_per");

                entity.Property(e => e.HvGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hv_group");

                entity.Property(e => e.HvLiveCostPerKg)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hv_live_cost_perKg");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmHerdWeight>(entity =>
            {
                entity.HasKey(e => e.HwIndex);

                entity.ToTable("pmm_herd_weight");

                entity.Property(e => e.HwIndex).HasColumnName("hw_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.HwAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hw_animalID");

                entity.Property(e => e.HwDate)
                    .HasColumnType("datetime")
                    .HasColumnName("hw_date");

                entity.Property(e => e.HwGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hw_group");

                entity.Property(e => e.HwGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hw_group_no");

                entity.Property(e => e.HwSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hw_sub_group");

                entity.Property(e => e.HwWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hw_weight");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmHerdX>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_herd_x");

                entity.Property(e => e.HcActive).HasColumnName("hc_active");

                entity.Property(e => e.HcAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_animal_id");

                entity.Property(e => e.HcDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("hc_date_born");

                entity.Property(e => e.HcFarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_farm_id");

                entity.Property(e => e.HcGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_group");

                entity.Property(e => e.HcGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_group_no");

                entity.Property(e => e.HcIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("hc_index");

                entity.Property(e => e.HcParentSow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_parent_sow");
            });

            modelBuilder.Entity<PmmHousingPen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_housing_pens");

                entity.Property(e => e.AccomodationSize).HasMaxLength(50);

                entity.Property(e => e.CurrentPopulation).HasMaxLength(50);

                entity.Property(e => e.Dimensions).HasMaxLength(50);

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .HasColumnName("farm_id");

                entity.Property(e => e.Feeders).HasMaxLength(50);

                entity.Property(e => e.FeedingTroughs).HasMaxLength(50);

                entity.Property(e => e.Indx).HasColumnName("indx");

                entity.Property(e => e.PenId)
                    .HasMaxLength(50)
                    .HasColumnName("PenID");

                entity.Property(e => e.Purpose).HasMaxLength(50);

                entity.Property(e => e.Waterers).HasMaxLength(50);
            });

            modelBuilder.Entity<PmmLogPublisher>(entity =>
            {
                entity.HasKey(e => e.LogIndex);

                entity.ToTable("pmm_log_publisher");

                entity.Property(e => e.LogIndex).HasColumnName("log_index");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("created_on");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_on");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.NewRecords).HasColumnName("new_records");

                entity.Property(e => e.TotalRecords).HasColumnName("total_records");
            });

            modelBuilder.Entity<PmmReport>(entity =>
            {
                entity.HasKey(e => e.RptIdx);

                entity.ToTable("pmm_reports");

                entity.Property(e => e.RptIdx).HasColumnName("rpt_idx");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ReportDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("report_display_name");

                entity.Property(e => e.ReportIndex)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report_index");

                entity.Property(e => e.ReportModule)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("report_module");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("report_name");

                entity.Property(e => e.ReportOrder)
                    .HasColumnType("numeric(5, 1)")
                    .HasColumnName("report_order");
            });

            modelBuilder.Entity<PmmSalesPlan>(entity =>
            {
                entity.HasKey(e => e.SpIndex);

                entity.ToTable("pmm_sales_plan");

                entity.Property(e => e.SpIndex).HasColumnName("sp_index");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AnimalID");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.DressedValuePerAnimal)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("DressedValue_per_animal")
                    .HasComputedColumnSql("((([LiveWt_per_Animal]*[dressing_per])/(100))*[DressedWt_price])", false);

                entity.Property(e => e.DressedValuePerGroup)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("DressedValue_per_group")
                    .HasComputedColumnSql("(((([LiveWt_per_Animal]*[dressing_per])/(100))*[DressedWt_price])*[No_Sold])", false);

                entity.Property(e => e.DressedWtPrice)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("DressedWt_Price");

                entity.Property(e => e.DressedwtPerAnimal)
                    .HasColumnType("decimal(35, 12)")
                    .HasColumnName("dressedwt_per_animal")
                    .HasComputedColumnSql("(([LiveWt_per_Animal]*[dressing_per])/(100))", false);

                entity.Property(e => e.DressedwtPerGroup)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("dressedwt_per_group")
                    .HasComputedColumnSql("((([LiveWt_per_Animal]*[dressing_per])/(100))*[No_sold])", false);

                entity.Property(e => e.DressingPer)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("dressing_per");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LiveValuePerAnimal)
                    .HasColumnType("decimal(31, 8)")
                    .HasColumnName("LiveValue_per_Animal")
                    .HasComputedColumnSql("([LiveWt_per_Animal]*[LiveWt_price])", false);

                entity.Property(e => e.LiveValuePerGroup)
                    .HasColumnType("decimal(38, 6)")
                    .HasColumnName("LiveValue_per_Group")
                    .HasComputedColumnSql("(([LiveWt_per_Animal]*[LiveWt_price])*[No_Sold])", false);

                entity.Property(e => e.LiveWtPerAnimal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("LiveWt_Per_animal");

                entity.Property(e => e.LiveWtPerGroup)
                    .HasColumnType("decimal(31, 4)")
                    .HasColumnName("LiveWt_per_group")
                    .HasComputedColumnSql("([No_Sold]*[LiveWt_Per_animal])", false);

                entity.Property(e => e.LiveWtPrice)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("LiveWt_price");

                entity.Property(e => e.NoAvailable)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("No_Available");

                entity.Property(e => e.NoSold)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("No_Sold");

                entity.Property(e => e.SaleDateFrom).HasColumnType("datetime");

                entity.Property(e => e.SaleDateTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<PmmSalesTransaction>(entity =>
            {
                entity.HasKey(e => e.StIndex);

                entity.ToTable("pmm_sales_transaction");

                entity.Property(e => e.StIndex).HasColumnName("st_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.StAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_animal_id");

                entity.Property(e => e.StCurDressedPrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_price");

                entity.Property(e => e.StCurDressedTotalValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_total_value");

                entity.Property(e => e.StCurDressedTotalWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_total_wt");

                entity.Property(e => e.StCurDressedValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_value");

                entity.Property(e => e.StCurDressedWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_wt");

                entity.Property(e => e.StCurDressingPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressing_per");

                entity.Property(e => e.StCurLivePrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_live_price");

                entity.Property(e => e.StCurLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_live_value");

                entity.Property(e => e.StCurLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_live_wt");

                entity.Property(e => e.StCurTotalLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_total_live_value");

                entity.Property(e => e.StCurTotalLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_total_live_wt");

                entity.Property(e => e.StDate)
                    .HasColumnType("datetime")
                    .HasColumnName("st_date");

                entity.Property(e => e.StExpDressedPrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_price");

                entity.Property(e => e.StExpDressedTotalValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_total_value");

                entity.Property(e => e.StExpDressedTotalWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_total_wt");

                entity.Property(e => e.StExpDressedValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_value");

                entity.Property(e => e.StExpDressedWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_wt");

                entity.Property(e => e.StExpDressingPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressing_per");

                entity.Property(e => e.StExpLivePrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_Exp_live_price");

                entity.Property(e => e.StExpLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_live_value");

                entity.Property(e => e.StExpLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_live_wt");

                entity.Property(e => e.StExpSaleDtFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("st_exp_saleDt_from");

                entity.Property(e => e.StExpSaleDtTo)
                    .HasColumnType("datetime")
                    .HasColumnName("st_exp_saleDt_To");

                entity.Property(e => e.StExpTotalLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_total_live_value");

                entity.Property(e => e.StExpTotalLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_total_live_wt");

                entity.Property(e => e.StGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_group");

                entity.Property(e => e.StGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("st_group_no");

                entity.Property(e => e.StLiveOrdressed).HasColumnName("st_liveORDressed");

                entity.Property(e => e.StNoSold)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("st_No_sold");

                entity.Property(e => e.StReferenceNo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("st_reference_no")
                    .HasComputedColumnSql("(CONVERT([varchar](10),[st_index],(0))+[st_animal_id])", false);

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmSerial>(entity =>
            {
                entity.HasKey(e => e.SerialIndex);

                entity.ToTable("pmm_serials");

                entity.Property(e => e.SerialIndex).HasColumnName("serial_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SerialName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("serial_name");

                entity.Property(e => e.SerialNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("serial_no");
            });

            modelBuilder.Entity<PmmServiceChargeLog>(entity =>
            {
                entity.HasKey(e => e.ChargeLogIndex);

                entity.ToTable("pmm_service_charge_log");

                entity.Property(e => e.ChargeLogIndex).HasColumnName("charge_log_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ChargeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("charge_date");

                entity.Property(e => e.ChargeLogId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("charge_log_id");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.NoOfAnimals)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("no_of_animals");

                entity.Property(e => e.PayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pay_date");

                entity.Property(e => e.PayKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pay_key");

                entity.Property(e => e.RangeAmount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("range_amount");

                entity.Property(e => e.RangeFrom)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("range_from");

                entity.Property(e => e.RangeTo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("range_to");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.UnitAmount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("unit_amount");
            });

            modelBuilder.Entity<PmmSetup>(entity =>
            {
                entity.HasKey(e => e.SetupIndex);

                entity.ToTable("pmm_setup");

                entity.Property(e => e.SetupIndex).HasColumnName("setup_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SetupCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_category");

                entity.Property(e => e.SetupDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("setup_description");

                entity.Property(e => e.SetupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_name");

                entity.Property(e => e.SetupValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_value");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmStandard>(entity =>
            {
                entity.HasKey(e => e.StdIndex);

                entity.ToTable("pmm_standards");

                entity.Property(e => e.StdIndex).HasColumnName("std_index");

                entity.Property(e => e.StdGroup)
                    .HasMaxLength(50)
                    .HasColumnName("std_group");

                entity.Property(e => e.StdWeekFrom)
                    .HasMaxLength(50)
                    .HasColumnName("std_week_from");

                entity.Property(e => e.StdWeekTo)
                    .HasMaxLength(50)
                    .HasColumnName("std_week_to");

                entity.Property(e => e.StdWeightFrom)
                    .HasMaxLength(50)
                    .HasColumnName("std_weight_from");

                entity.Property(e => e.StdWeightTo)
                    .HasMaxLength(50)
                    .HasColumnName("std_weight_to");
            });

            modelBuilder.Entity<PmmStockTakeEntry>(entity =>
            {
                entity.HasKey(e => e.StockIndex);

                entity.ToTable("pmm_stockTake_entry");

                entity.Property(e => e.StockIndex).HasColumnName("stock_index");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Counted).HasColumnType("decimal(15, 0)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SheetNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sheet_no");

                entity.Property(e => e.StockNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("stock_no");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PmmStockTakeSlave>(entity =>
            {
                entity.HasKey(e => e.StockIndex);

                entity.ToTable("pmm_stockTake_slave");

                entity.Property(e => e.StockIndex).HasColumnName("stock_index");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AnimalID");

                entity.Property(e => e.CopiesNo).HasColumnType("decimal(15, 0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNo).HasColumnType("decimal(15, 0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StockNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("Stock_No");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PmmStockTakeUpdate>(entity =>
            {
                entity.HasKey(e => e.StockIndex);

                entity.ToTable("pmm_stockTake_update");

                entity.Property(e => e.StockIndex).HasColumnName("stock_index");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AnimalID");

                entity.Property(e => e.CountedNo).HasColumnType("decimal(15, 0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.Filter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreCountNo).HasColumnType("decimal(15, 0)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StockNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("Stock_No");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.VarianceNo).HasColumnType("decimal(15, 0)");
            });

            modelBuilder.Entity<PmmStockUpdateLog>(entity =>
            {
                entity.HasKey(e => e.UpdateIndex);

                entity.ToTable("pmm_StockUpdate_log");

                entity.Property(e => e.UpdateIndex).HasColumnName("update_index");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PmmStocktakeMst>(entity =>
            {
                entity.HasKey(e => e.StockIndex);

                entity.ToTable("pmm_stocktake_mst");

                entity.Property(e => e.StockIndex).HasColumnName("stock_index");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.Filter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockNo).HasColumnName("stock_No");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<PmmStorageFacility>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pmm_storage_facility");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("date")
                    .HasColumnName("date_added");

                entity.Property(e => e.Dimensions)
                    .HasMaxLength(50)
                    .HasColumnName("dimensions");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .HasColumnName("farm_id");

                entity.Property(e => e.Indx)
                    .HasMaxLength(50)
                    .HasColumnName("indx");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(50)
                    .HasColumnName("purpose");

                entity.Property(e => e.StorageCapacity)
                    .HasMaxLength(50)
                    .HasColumnName("storage_capacity");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(50)
                    .HasColumnName("store_id");
            });

            modelBuilder.Entity<PmmSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierIndex);

                entity.ToTable("pmm_suppliers");

                entity.Property(e => e.SupplierIndex).HasColumnName("supplier_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("county");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(50)
                    .HasColumnName("farm_name");

                entity.Property(e => e.ParentFarm)
                    .HasMaxLength(50)
                    .HasColumnName("parent_farm");

                entity.Property(e => e.SupplierEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_email");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_id");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_name");

                entity.Property(e => e.SupplierPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_phone");

                entity.Property(e => e.SupplierTown)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_town");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmSupplimentDrug>(entity =>
            {
                entity.HasKey(e => e.SdIndex);

                entity.ToTable("pmm_suppliment_drug");

                entity.Property(e => e.SdIndex).HasColumnName("sd_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.SdActive).HasColumnName("sd_active");

                entity.Property(e => e.SdAnimalId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sd_animal_id");

                entity.Property(e => e.SdCostPerAnimal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("sd_cost_per_animal");

                entity.Property(e => e.SdCostPerKg)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("sd_cost_per_kg");

                entity.Property(e => e.SdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sd_date");

                entity.Property(e => e.SdGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sd_group");

                entity.Property(e => e.SdGroupNo)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("sd_group_no");

                entity.Property(e => e.SdName)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("sd_name");

                entity.Property(e => e.SdQuantityPerAnimal)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("sd_quantity_per_animal");

                entity.Property(e => e.SdTotalCost)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("sd_total_cost");

                entity.Property(e => e.SdTotalQuantity)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("sd_total_quantity");

                entity.Property(e => e.SdType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sd_type");

                entity.Property(e => e.SdUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sd_unit");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<PmmTrialBalance>(entity =>
            {
                entity.HasKey(e => e.TbalIndex);

                entity.ToTable("pmm_trial_balance");

                entity.Property(e => e.TbalIndex)
                    .ValueGeneratedNever()
                    .HasColumnName("tbal_index");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.TbalAmount)
                    .HasColumnType("decimal(15, 4)")
                    .HasColumnName("tbal_amount");

                entity.Property(e => e.TbalDetails)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tbal_details");

                entity.Property(e => e.TbalDrCr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tbal_dr_cr");

                entity.Property(e => e.TbalSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tbal_source");
            });

            modelBuilder.Entity<PmmUser>(entity =>
            {
                entity.HasKey(e => e.UserIndex);

                entity.ToTable("pmm_users");

                entity.Property(e => e.UserIndex).HasColumnName("user_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("group_name");

                entity.Property(e => e.UserActive).HasColumnName("user_active");

                entity.Property(e => e.UserFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_fname");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserOname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_Oname");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_password");
            });

            modelBuilder.Entity<PmmUserGroup>(entity =>
            {
                entity.HasKey(e => e.GroupIndex);

                entity.ToTable("pmm_user_groups");

                entity.Property(e => e.GroupIndex).HasColumnName("group_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.GroupActive).HasColumnName("group_active");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("group_name");
            });

            modelBuilder.Entity<PmmUserGroupRight>(entity =>
            {
                entity.HasKey(e => e.GroupRightIndex);

                entity.ToTable("pmm_user_group_right");

                entity.Property(e => e.GroupRightIndex).HasColumnName("group_right_index");

                entity.Property(e => e.Add).HasColumnName("add");

                entity.Property(e => e.Delete).HasColumnName("delete");

                entity.Property(e => e.Edit).HasColumnName("edit");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("group_name");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.View).HasColumnName("view");
            });

            modelBuilder.Entity<PmmUserModule>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("pmm_user_modules");

                entity.Property(e => e.ModuleId).HasColumnName("module_id");

                entity.Property(e => e.Add).HasColumnName("add");

                entity.Property(e => e.Delete).HasColumnName("delete");

                entity.Property(e => e.Edit).HasColumnName("edit");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.ModuleIndex).HasColumnName("module_index");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("module_name");

                entity.Property(e => e.View).HasColumnName("view");
            });

            modelBuilder.Entity<PmmUsers2>(entity =>
            {
                entity.HasKey(e => e.UserIndex);

                entity.ToTable("pmm_users_2");

                entity.Property(e => e.UserIndex).HasColumnName("user_index");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("group_name");

                entity.Property(e => e.UserActive).HasColumnName("user_active");

                entity.Property(e => e.UserFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_fname");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserOname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_Oname");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_password");
            });

            modelBuilder.Entity<TmpDepsSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_deps_summary");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("farm_id");

                entity.Property(e => e.FpAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fp_animal_id");

                entity.Property(e => e.FpCycleNo).HasColumnName("fp_cycle_no");

                entity.Property(e => e.FpDepsNo).HasColumnName("fp_deps_no");

                entity.Property(e => e.FpIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fp_index");
            });

            modelBuilder.Entity<VApplicationSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_ApplicationSetup");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.SetupCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_category");

                entity.Property(e => e.SetupDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("setup_description");

                entity.Property(e => e.SetupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_name");

                entity.Property(e => e.SetupValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_value");
            });

            modelBuilder.Entity<VPmmCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_pmm_countries");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_id");

                entity.Property(e => e.CountryIndex)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("country_index");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_name");

                entity.Property(e => e.SvcStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("svc_status");
            });

            modelBuilder.Entity<ViewCurrentBreedingPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CurrentBreedingPlan");

                entity.Property(e => e.BpBatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_batchID");

                entity.Property(e => e.BpBoarId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_boarID");

                entity.Property(e => e.BpCycleIndex).HasColumnName("bp_cycle_index");

                entity.Property(e => e.BpDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_date_born");

                entity.Property(e => e.BpExpBorn)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_exp_born");

                entity.Property(e => e.BpExpDeadPost)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_dead_post");

                entity.Property(e => e.BpExpDeadPre)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_dead_pre");

                entity.Property(e => e.BpExpKiddlingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_kiddling_dt");

                entity.Property(e => e.BpExpPostweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_postwean_mort");

                entity.Property(e => e.BpExpPreweanMort)
                    .HasColumnType("decimal(15, 1)")
                    .HasColumnName("bp_exp_prewean_mort");

                entity.Property(e => e.BpExpServingDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_serving_dt");

                entity.Property(e => e.BpExpWeaned)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("bp_exp_weaned");

                entity.Property(e => e.BpExpWeaningDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bp_exp_weaning_dt");

                entity.Property(e => e.BpGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_group");

                entity.Property(e => e.BpSowId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_sowID");

                entity.Property(e => e.BpStatus).HasColumnName("bp_status");

                entity.Property(e => e.BpSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bp_sub_group");

                entity.Property(e => e.FarmCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");
            });

            modelBuilder.Entity<ViewFeedingPlanRoutine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_FeedingPlanRoutine");

                entity.Property(e => e.FarmCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.FrActive).HasColumnName("fr_active");

                entity.Property(e => e.FrAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_animal_id");

                entity.Property(e => e.FrConcName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_conc_name");

                entity.Property(e => e.FrConcPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_conc_per");

                entity.Property(e => e.FrConcWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_conc_weight");

                entity.Property(e => e.FrCurAge)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_cur_age");

                entity.Property(e => e.FrCurConcPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_cur_conc_per");

                entity.Property(e => e.FrCurDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fr_cur_date");

                entity.Property(e => e.FrCurFodPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_cur_fod_per");

                entity.Property(e => e.FrCurWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_cur_weight");

                entity.Property(e => e.FrCycle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_cycle");

                entity.Property(e => e.FrDailyRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_daily_ration");

                entity.Property(e => e.FrDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("fr_date_born");

                entity.Property(e => e.FrDependantsNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_dependants_no");

                entity.Property(e => e.FrExpDailyRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_exp_daily_ration");

                entity.Property(e => e.FrExpDepDailyRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_exp_dep_daily_ration");

                entity.Property(e => e.FrExpTotalRation)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_exp_total_ration");

                entity.Property(e => e.FrFodName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_fod_name");

                entity.Property(e => e.FrFodPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_fod_per");

                entity.Property(e => e.FrFodWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("fr_fod_weight");

                entity.Property(e => e.FrGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_group");

                entity.Property(e => e.FrGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("fr_group_no");

                entity.Property(e => e.FrSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fr_sub_group");
            });

            modelBuilder.Entity<ViewHerdComposition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_HerdComposition");

                entity.Property(e => e.FarmCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.HcActive).HasColumnName("hc_active");

                entity.Property(e => e.HcAge)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_age");

                entity.Property(e => e.HcAgeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_age_unit");

                entity.Property(e => e.HcAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_animal_id");

                entity.Property(e => e.HcCycle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_cycle");

                entity.Property(e => e.HcDateBorn)
                    .HasColumnType("datetime")
                    .HasColumnName("hc_date_born");

                entity.Property(e => e.HcDateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("hc_date_created");

                entity.Property(e => e.HcGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_group");

                entity.Property(e => e.HcGroupBought)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_group_bought");

                entity.Property(e => e.HcGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_group_no");

                entity.Property(e => e.HcGroupValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_group_value");

                entity.Property(e => e.HcOpenningStock)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_openning_stock");

                entity.Property(e => e.HcParentBoar)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_parent_boar");

                entity.Property(e => e.HcParentSow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_parent_sow");

                entity.Property(e => e.HcSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_source");

                entity.Property(e => e.HcSubGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_sub_group");

                entity.Property(e => e.HcUnitCost)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_unit_cost");

                entity.Property(e => e.HcWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_weight");

                entity.Property(e => e.HcWeightUnits)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_weight_units");
            });

            modelBuilder.Entity<ViewSaleOverdue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SaleOverdue");

                entity.Property(e => e.ExpSaleDate).HasColumnType("datetime");

                entity.Property(e => e.FarmCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.HcAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_animal_id");

                entity.Property(e => e.HcGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hc_group");

                entity.Property(e => e.HcGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("hc_group_no");

                entity.Property(e => e.HcWeight)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("hc_weight");

                entity.Property(e => e.OverSaleDays).HasColumnName("overSaleDays");
            });

            modelBuilder.Entity<ViewSaleTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SaleTransactions");

                entity.Property(e => e.FarmCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.StAnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_animal_id");

                entity.Property(e => e.StCurDressedPrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_price");

                entity.Property(e => e.StCurDressedTotalValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_total_value");

                entity.Property(e => e.StCurDressedTotalWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_total_wt");

                entity.Property(e => e.StCurDressedValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_value");

                entity.Property(e => e.StCurDressedWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressed_wt");

                entity.Property(e => e.StCurDressingPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_dressing_per");

                entity.Property(e => e.StCurLivePrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_live_price");

                entity.Property(e => e.StCurLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_live_value");

                entity.Property(e => e.StCurLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_live_wt");

                entity.Property(e => e.StCurTotalLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_total_live_value");

                entity.Property(e => e.StCurTotalLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_cur_total_live_wt");

                entity.Property(e => e.StDate)
                    .HasColumnType("datetime")
                    .HasColumnName("st_date");

                entity.Property(e => e.StExpDressedPrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_price");

                entity.Property(e => e.StExpDressedTotalValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_total_value");

                entity.Property(e => e.StExpDressedTotalWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_total_wt");

                entity.Property(e => e.StExpDressedValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_value");

                entity.Property(e => e.StExpDressedWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressed_wt");

                entity.Property(e => e.StExpDressingPer)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_dressing_per");

                entity.Property(e => e.StExpLivePrice)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_Exp_live_price");

                entity.Property(e => e.StExpLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_live_value");

                entity.Property(e => e.StExpLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_live_wt");

                entity.Property(e => e.StExpSaleDtFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("st_exp_saleDt_from");

                entity.Property(e => e.StExpSaleDtTo)
                    .HasColumnType("datetime")
                    .HasColumnName("st_exp_saleDt_To");

                entity.Property(e => e.StExpTotalLiveValue)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_total_live_value");

                entity.Property(e => e.StExpTotalLiveWt)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("st_exp_total_live_wt");

                entity.Property(e => e.StGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("st_group");

                entity.Property(e => e.StGroupNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("st_group_no");

                entity.Property(e => e.StLiveOrdressed).HasColumnName("st_liveORDressed");

                entity.Property(e => e.StNoSold)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("st_No_sold");
            });

            modelBuilder.Entity<ViewStockTakeSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_StockTakeSheet");

                entity.Property(e => e.AnimalId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AnimalID");

                entity.Property(e => e.FarmCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_County");

                entity.Property(e => e.FarmId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Id");

                entity.Property(e => e.FarmName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Farm_Name");

                entity.Property(e => e.Group)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StockNo)
                    .HasColumnType("decimal(15, 0)")
                    .HasColumnName("Stock_No");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
