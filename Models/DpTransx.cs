using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpTransx
{
    public long Id { get; set; }

    public string? Narration { get; set; }

    public decimal Debit { get; set; }

    public decimal Credit { get; set; }

    public string Recipient { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string InstCode { get; set; } = null!;

    public string Statuz { get; set; } = null!;

    public string TransId { get; set; } = null!;

    public string TransDate { get; set; } = null!;

    public string? DateModified { get; set; }

    public decimal? Commission { get; set; }

    public string? CategoryId { get; set; }

    public string? ProviderId { get; set; }

    public string? Extras { get; set; }

    public string? BranchCode { get; set; }

    public string? Descr { get; set; }

    public string? ValueDate { get; set; }

    public string? AccNumber { get; set; }

    public string? Xmode { get; set; }

    public string? Tsrc { get; set; }

    public decimal? Charge { get; set; }
}
