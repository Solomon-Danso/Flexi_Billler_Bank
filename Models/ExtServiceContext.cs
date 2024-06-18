using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Flexi_Biller_Back.Models;

public partial class ExtServiceContext : DbContext
{
    public ExtServiceContext()
    {
    }

    public ExtServiceContext(DbContextOptions<ExtServiceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DpActivityx> DpActivityxes { get; set; }

    public virtual DbSet<DpAdvert> DpAdverts { get; set; }

    public virtual DbSet<DpAppsettingsx> DpAppsettingsxes { get; set; }

    public virtual DbSet<DpBank> DpBanks { get; set; }

    public virtual DbSet<DpCountry> DpCountries { get; set; }

    public virtual DbSet<DpGlyde> DpGlydes { get; set; }

    public virtual DbSet<DpInstitution> DpInstitutions { get; set; }

    public virtual DbSet<DpLeave> DpLeaves { get; set; }

    public virtual DbSet<DpNotification> DpNotifications { get; set; }

    public virtual DbSet<DpState> DpStates { get; set; }

    public virtual DbSet<DpTicket> DpTickets { get; set; }

    public virtual DbSet<DpTicketsmessage> DpTicketsmessages { get; set; }

    public virtual DbSet<DpTransactionsExt> DpTransactionsExts { get; set; }

    public virtual DbSet<DpTransx> DpTransxes { get; set; }

    public virtual DbSet<DpUserRole> DpUserRoles { get; set; }

    public virtual DbSet<DpUserx> DpUserxes { get; set; }
    public virtual DbSet<InstituitionBillingTable> BillingTable { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=extService;User=sa;Password=HydotTech;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DpActivityx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dp_activity");

            entity.ToTable("dp_activityx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("action");
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("branch");
            entity.Property(e => e.Browser)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("browser");
            entity.Property(e => e.TimeLog)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("timeLog");
            entity.Property(e => e.UserData)
                .IsUnicode(false)
                .HasColumnName("userData");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userIP");
        });

        modelBuilder.Entity<DpAdvert>(entity =>
        {
            entity.ToTable("dp_adverts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateCreated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Created");
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extras).IsUnicode(false);
            entity.Property(e => e.ShortName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Statuz)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DpAppsettingsx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dp_appse__3214EC07F9F1F285");

            entity.ToTable("dp_appsettingsx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Settings)
                .HasMaxLength(50)
                .HasColumnName("settings");
            entity.Property(e => e.Svalue).HasColumnName("svalue");
        });

        modelBuilder.Entity<DpBank>(entity =>
        {
            entity.ToTable("dp_banks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Isocountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ISOCountry");
        });

        modelBuilder.Entity<DpCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dp_country");

            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("currency");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Iname).HasColumnName("iname");
            entity.Property(e => e.Iso).HasColumnName("iso");
            entity.Property(e => e.Iso3)
                .HasMaxLength(50)
                .HasColumnName("iso3");
            entity.Property(e => e.IsoCurrency)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("iso_currency");
            entity.Property(e => e.Oname).HasColumnName("oname");
            entity.Property(e => e.Phonecode).HasColumnName("phonecode");
        });

        modelBuilder.Entity<DpGlyde>(entity =>
        {
            entity.ToTable("dp_glyde");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("categoryID");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("countryCode");
            entity.Property(e => e.Credit)
                .HasColumnType("money")
                .HasColumnName("credit");
            entity.Property(e => e.DateModified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dateModified");
            entity.Property(e => e.Debit)
                .HasColumnType("money")
                .HasColumnName("debit");
            entity.Property(e => e.Discount)
                .HasColumnType("money")
                .HasColumnName("discount");
            entity.Property(e => e.Extras)
                .IsUnicode(false)
                .HasColumnName("extras");
            entity.Property(e => e.InstCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("instCode");
            entity.Property(e => e.Narration)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("providerID");
            entity.Property(e => e.Recipient)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recipient");
            entity.Property(e => e.Statuz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statuz");
            entity.Property(e => e.TransDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transDate");
            entity.Property(e => e.TransId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transID");
            entity.Property(e => e.TransType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transType");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.ValueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DpInstitution>(entity =>
        {
            entity.ToTable("dp_institutions");

            entity.HasIndex(e => e.ShortName, "IX_ShortName").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccNoType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccrualSreverse)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AccrualSReverse");
            entity.Property(e => e.AccrualSusp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Acoset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACOSet");
            entity.Property(e => e.Aitset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AITSet");
            entity.Property(e => e.Attset)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTSet");
            entity.Property(e => e.BaseUrl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BaseURL");
            entity.Property(e => e.BbankingSet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BBankingSet");
            entity.Property(e => e.BillingPlan).HasColumnName("billingPlan");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.Csrf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSRF");
            entity.Property(e => e.CustLen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Created");
            entity.Property(e => e.DateUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Updated");
            entity.Property(e => e.EmptyTill)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtSet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExtUrl)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Extras).IsUnicode(false);
            entity.Property(e => e.FdintCalcDays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FDIntCalcDays");
            entity.Property(e => e.FysendDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FYSEndDate");
            entity.Property(e => e.IbankingSet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IBankingSet");
            entity.Property(e => e.Ibsettlement)
                .HasMaxLength(10)
                .HasDefaultValue("X")
                .IsFixedLength()
                .HasColumnName("IBSettlement");
            entity.Property(e => e.Ifrmode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IFRMode");
            entity.Property(e => e.InstBilling)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstCommBus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstCpemail)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("InstCPEmail");
            entity.Property(e => e.InstCpemailSet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InstCPEmailSet");
            entity.Property(e => e.InstCperson)
                .IsUnicode(false)
                .HasColumnName("InstCPerson");
            entity.Property(e => e.InstCpphone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InstCPPhone");
            entity.Property(e => e.InstCurrency)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstEmailSet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstFkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("InstFKey");
            entity.Property(e => e.InstFkeySet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InstFKeySet");
            entity.Property(e => e.InstIncCert)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstLicense)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstMigCodate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InstMigCODate");
            entity.Property(e => e.InstPkg)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InstType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lhsector)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LHSector");
            entity.Property(e => e.LintCalcDays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LIntCalcDays");
            entity.Property(e => e.LoanHub)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Logo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.NameInst).IsUnicode(false);
            entity.Property(e => e.Nbranch)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NBranch");
            entity.Property(e => e.Nspace)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NSpace");
            entity.Property(e => e.Nuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUser");
            entity.Property(e => e.OdintCalcDays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ODIntCalcDays");
            entity.Property(e => e.PrdCacc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrdCAcc");
            entity.Property(e => e.PrdCodeSet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrdCsacc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrdCSAcc");
            entity.Property(e => e.PrdLacc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrdLAcc");
            entity.Property(e => e.PrdSacc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrdSAcc");
            entity.Property(e => e.PrdTdacc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PrdTDAcc");
            entity.Property(e => e.ShortName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Statuz)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SystemDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TillState)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
        });

        modelBuilder.Entity<DpLeave>(entity =>
        {
            entity.ToTable("dp_leave");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Approved_By");
            entity.Property(e => e.Branch)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commentx)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.DateApproved)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Approved");
            entity.Property(e => e.DateCreated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Created");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ndays)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NDays");
            entity.Property(e => e.StartDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("P");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userID");
        });

        modelBuilder.Entity<DpNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dp_notification");

            entity.ToTable("dp_notifications");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateInitiated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date_initiated");
            entity.Property(e => e.DateModified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("date_modified");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Recipient)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("recipient");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.SenderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("senderID");
            entity.Property(e => e.Statuz)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("statuz");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userID");
        });

        modelBuilder.Entity<DpState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dp_states");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Iso3)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("iso3");
            entity.Property(e => e.Oname).HasColumnName("oname");
            entity.Property(e => e.Scode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("scode");
        });

        modelBuilder.Entity<DpTicket>(entity =>
        {
            entity.ToTable("dp_tickets");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datecreated)
                .HasMaxLength(50)
                .HasColumnName("datecreated");
            entity.Property(e => e.Emailaddress)
                .HasMaxLength(50)
                .HasColumnName("emailaddress");
            entity.Property(e => e.Extras).HasColumnName("extras");
            entity.Property(e => e.Lastreplyby)
                .HasMaxLength(50)
                .HasColumnName("lastreplyby");
            entity.Property(e => e.Lastupdated)
                .HasMaxLength(50)
                .HasColumnName("lastupdated");
            entity.Property(e => e.Sendername)
                .HasMaxLength(50)
                .HasColumnName("sendername");
            entity.Property(e => e.Shortname)
                .HasMaxLength(50)
                .HasColumnName("shortname");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .HasColumnName("subject");
            entity.Property(e => e.Ticketid)
                .HasMaxLength(50)
                .HasColumnName("ticketid");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");
        });

        modelBuilder.Entity<DpTicketsmessage>(entity =>
        {
            entity.ToTable("dp_ticketsmessages");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Attachements).HasColumnName("attachements");
            entity.Property(e => e.Extras).HasColumnName("extras");
            entity.Property(e => e.Messagecontent).HasColumnName("messagecontent");
            entity.Property(e => e.Ticketid)
                .HasMaxLength(50)
                .HasColumnName("ticketid");
        });

        modelBuilder.Entity<DpTransactionsExt>(entity =>
        {
            entity.ToTable("dp_transactionsExt");

            entity.HasIndex(e => e.ForeignId, "IX_ForeignKey").IsUnique();

            entity.HasIndex(e => e.TransId, "IX_transID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AccNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AccountID");
            entity.Property(e => e.Charge)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.CheckerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CheckerID");
            entity.Property(e => e.CheckerTs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CheckerTS");
            entity.Property(e => e.Credit).HasColumnType("money");
            entity.Property(e => e.DateUpdated)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Debit).HasColumnType("money");
            entity.Property(e => e.DestBank)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Extras).IsUnicode(false);
            entity.Property(e => e.ForeignId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ForeignID");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.MakerId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MakerID");
            entity.Property(e => e.MakerTs)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MakerTS");
            entity.Property(e => e.Narration)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.SessionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SessionID");
            entity.Property(e => e.SrcBank)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Statuz)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TransId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TransID");
            entity.Property(e => e.TransType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tsrc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSrc");
            entity.Property(e => e.ValueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DpTransx>(entity =>
        {
            entity.ToTable("dp_transx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("branchCode");
            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("categoryID");
            entity.Property(e => e.Charge).HasColumnType("money");
            entity.Property(e => e.Commission)
                .HasColumnType("money")
                .HasColumnName("commission");
            entity.Property(e => e.Credit)
                .HasColumnType("money")
                .HasColumnName("credit");
            entity.Property(e => e.DateModified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dateModified");
            entity.Property(e => e.Debit)
                .HasColumnType("money")
                .HasColumnName("debit");
            entity.Property(e => e.Descr)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descr");
            entity.Property(e => e.Extras)
                .IsUnicode(false)
                .HasColumnName("extras");
            entity.Property(e => e.InstCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("instCode");
            entity.Property(e => e.Narration)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("narration");
            entity.Property(e => e.ProviderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("providerID");
            entity.Property(e => e.Recipient)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("recipient");
            entity.Property(e => e.Statuz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statuz");
            entity.Property(e => e.TransDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transDate");
            entity.Property(e => e.TransId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("transID");
            entity.Property(e => e.Tsrc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TSrc");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.ValueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Xmode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("XMode");
        });

        modelBuilder.Entity<DpUserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_userRoles");

            entity.ToTable("dp_userRoles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Deleted)
                .HasMaxLength(10)
                .HasColumnName("deleted");
            entity.Property(e => e.Extras).HasColumnName("extras");
            entity.Property(e => e.Ownedby)
                .HasMaxLength(10)
                .HasColumnName("ownedby");
            entity.Property(e => e.RoleName).HasMaxLength(50);
        });

        modelBuilder.Entity<DpUserx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dp_users");

            entity.ToTable("dp_userx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccLevel)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ApiKey)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Arole)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARole");
            entity.Property(e => e.Branch)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Created_By");
            entity.Property(e => e.DateCreated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Created");
            entity.Property(e => e.DateUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Date_Updated");
            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternalID");
            entity.Property(e => e.Extras)
                .IsUnicode(false)
                .HasColumnName("extras");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grole)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRole");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LastLogin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Pswd)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("pswd");
            entity.Property(e => e.Smsbalance).HasColumnName("SMSBalance");
            entity.Property(e => e.Srole)
                .IsUnicode(false)
                .HasColumnName("SRole");
            entity.Property(e => e.Statuz)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Udobirth)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UDOBirth");
            entity.Property(e => e.Uemail)
                .HasMaxLength(100)
                .HasColumnName("UEmail");
            entity.Property(e => e.Ugender)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UGender");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Updated_By");
            entity.Property(e => e.Uphone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPhone");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userID");
            entity.Property(e => e.Utitle)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("UTitle");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
