using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpInstitution
{
    public int Id { get; set; }

    public string? Attset { get; set; }

    public string? AccNoType { get; set; }

    public string? AccrualSreverse { get; set; }

    public string? AccrualSusp { get; set; }

    public string? BbankingSet { get; set; }

    public string? Acoset { get; set; }

    public string? CustLen { get; set; }

    public string? FysendDate { get; set; }

    public string? IbankingSet { get; set; }

    public string? Ifrmode { get; set; }

    public string? Aitset { get; set; }

    public string? InstBilling { get; set; }

    public string? InstCode { get; set; }

    public string? InstType { get; set; }

    public string? InstCurrency { get; set; }

    public string? InstCpemail { get; set; }

    public string? InstCpemailSet { get; set; }

    public string? InstCperson { get; set; }

    public string? InstCommBus { get; set; }

    public string? InstCountry { get; set; }

    public string? InstEmail { get; set; }

    public string? InstEmailSet { get; set; }

    public string? InstFkey { get; set; }

    public string? InstFkeySet { get; set; }

    public string? InstIncCert { get; set; }

    public string? InstLicense { get; set; }

    public string? InstMigCodate { get; set; }

    public string? InstPkg { get; set; }

    public string? Nbranch { get; set; }

    public string? Nspace { get; set; }

    public string? Nuser { get; set; }

    public string NameInst { get; set; } = null!;

    public string? PrdCacc { get; set; }

    public string? PrdCsacc { get; set; }

    public string? PrdCodeSet { get; set; }

    public string? PrdLacc { get; set; }

    public string? PrdSacc { get; set; }

    public string? PrdTdacc { get; set; }

    public string? BillingPlan { get; set; }

    public string? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public string? DateUpdated { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Csrf { get; set; }

    public string? Statuz { get; set; }

    public string? SystemDate { get; set; }

    public string? TillState { get; set; }

    public string? LintCalcDays { get; set; }

    public string? FdintCalcDays { get; set; }

    public string? Logo { get; set; }

    public string? EmptyTill { get; set; }

    public string? InstCpphone { get; set; }

    public string? ShortName { get; set; }

    public string? ExtSet { get; set; }

    public string? ExtUrl { get; set; }

    public string? Extras { get; set; }

    public string? LoanHub { get; set; }

    public string? Lhsector { get; set; }

    public string Ibsettlement { get; set; } = null!;

    public string? BaseUrl { get; set; }

    public string? OdintCalcDays { get; set; }
}
