using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flexi_Biller_Back.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnsToDpGlyde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BillingTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstituitionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInvoiceSent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccessDenied = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DaysLeft = table.Column<int>(type: "int", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dp_activityx",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    userData = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    userIP = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    timeLog = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    action = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    browser = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    branch = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_activity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_adverts",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EndDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Extras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Created_By = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_Created = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Statuz = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_adverts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_appsettingsx",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    settings = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    svalue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__dp_appse__3214EC07F9F1F285", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_banks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    BankCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ISOCountry = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_banks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_country",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iso3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    oname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phonecode = table.Column<short>(type: "smallint", nullable: true),
                    iso_currency = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    currency = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "dp_glyde",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    narration = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    debit = table.Column<decimal>(type: "money", nullable: false),
                    credit = table.Column<decimal>(type: "money", nullable: false),
                    userid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    instCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    statuz = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    transID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    transDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    dateModified = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    discount = table.Column<decimal>(type: "money", nullable: true),
                    categoryID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    providerID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    extras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    countryCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ValueDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    recipient = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    transType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstituitionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Branches = table.Column<int>(type: "int", nullable: false),
                    Users = table.Column<int>(type: "int", nullable: false),
                    DatabaseSize = table.Column<double>(type: "float", nullable: true),
                    AmountPaid = table.Column<double>(type: "float", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_glyde", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_institutions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ATTSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccNoType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccrualSReverse = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccrualSusp = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BBankingSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ACOSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CustLen = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FYSEndDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IBankingSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IFRMode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AITSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstBilling = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstCurrency = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstCPEmail = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    InstCPEmailSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstCPerson = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    InstCommBus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstCountry = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstEmail = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    InstEmailSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstFKey = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    InstFKeySet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstIncCert = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstLicense = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstMigCODate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstPkg = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NBranch = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NSpace = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NUser = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NameInst = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    PrdCAcc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PrdCSAcc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PrdCodeSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PrdLAcc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PrdSAcc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PrdTDAcc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    billingPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_Created = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_Updated = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Updated_By = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CSRF = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Statuz = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SystemDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TillState = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LIntCalcDays = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FDIntCalcDays = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Logo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    EmptyTill = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    InstCPPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ShortName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtSet = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExtUrl = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Extras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    LoanHub = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    LHSector = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    IBSettlement = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, defaultValue: "X"),
                    BaseURL = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ODIntCalcDays = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_institutions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_leave",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Branch = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StartDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EndDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NDays = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Department = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_Created = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "P"),
                    Date_Approved = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Approved_By = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Commentx = table.Column<string>(type: "varchar(5000)", unicode: false, maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_leave", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_notifications",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recipient = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    statuz = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    date_initiated = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    date_modified = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    userID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    senderID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_notification", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_states",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    iso3 = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    scode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    oname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "dp_tickets",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticketid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    shortname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    subject = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    datecreated = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastupdated = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    userid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    sendername = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    emailaddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastreplyby = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    extras = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_tickets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_ticketsmessages",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticketid = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    messagecontent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attachements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    extras = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_ticketsmessages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_transactionsExt",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Debit = table.Column<decimal>(type: "money", nullable: true),
                    Credit = table.Column<decimal>(type: "money", nullable: true),
                    Narration = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TransID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ForeignID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ValueDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateUpdated = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MakerID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MakerTS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CheckerID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CheckerTS = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SrcBank = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DestBank = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SessionID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    IPAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Statuz = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Extras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TransType = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccountID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Charge = table.Column<decimal>(type: "money", nullable: true, defaultValue: 0m),
                    TSrc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_transactionsExt", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_transx",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    narration = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    debit = table.Column<decimal>(type: "money", nullable: false),
                    credit = table.Column<decimal>(type: "money", nullable: false),
                    recipient = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    userid = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    instCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    statuz = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    transID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    transDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    dateModified = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    commission = table.Column<decimal>(type: "money", nullable: true),
                    categoryID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    providerID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    extras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    branchCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    descr = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ValueDate = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccNumber = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    XMode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TSrc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Charge = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_transx", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_userRoles",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RolePriv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ownedby = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    deleted = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    extras = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dp_userx",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    pswd = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    GRole = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SRole = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    ARole = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Statuz = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    ApiKey = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    LastLogin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AccLevel = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Branch = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    UDOBirth = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    UEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UGender = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    UPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UTitle = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Date_Created = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_Updated = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Updated_By = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ExternalID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    extras = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    SMSBalance = table.Column<long>(type: "bigint", nullable: false),
                    IPAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dp_users", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShortName",
                table: "dp_institutions",
                column: "ShortName",
                unique: true,
                filter: "[ShortName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ForeignKey",
                table: "dp_transactionsExt",
                column: "ForeignID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transID",
                table: "dp_transactionsExt",
                column: "TransID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingTable");

            migrationBuilder.DropTable(
                name: "dp_activityx");

            migrationBuilder.DropTable(
                name: "dp_adverts");

            migrationBuilder.DropTable(
                name: "dp_appsettingsx");

            migrationBuilder.DropTable(
                name: "dp_banks");

            migrationBuilder.DropTable(
                name: "dp_country");

            migrationBuilder.DropTable(
                name: "dp_glyde");

            migrationBuilder.DropTable(
                name: "dp_institutions");

            migrationBuilder.DropTable(
                name: "dp_leave");

            migrationBuilder.DropTable(
                name: "dp_notifications");

            migrationBuilder.DropTable(
                name: "dp_states");

            migrationBuilder.DropTable(
                name: "dp_tickets");

            migrationBuilder.DropTable(
                name: "dp_ticketsmessages");

            migrationBuilder.DropTable(
                name: "dp_transactionsExt");

            migrationBuilder.DropTable(
                name: "dp_transx");

            migrationBuilder.DropTable(
                name: "dp_userRoles");

            migrationBuilder.DropTable(
                name: "dp_userx");
        }
    }
}
