using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpTransactionsExt
{
    public long Id { get; set; }

    public string? AccNumber { get; set; }

    public string? AccName { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public string? Narration { get; set; }

    public string TransId { get; set; } = null!;

    public string ForeignId { get; set; } = null!;

    public string? ValueDate { get; set; }

    public string? DateUpdated { get; set; }

    public string? MakerId { get; set; }

    public string? MakerTs { get; set; }

    public string? CheckerId { get; set; }

    public string? CheckerTs { get; set; }

    public string? SrcBank { get; set; }

    public string? DestBank { get; set; }

    public string SessionId { get; set; } = null!;

    public string? Ipaddress { get; set; }

    public string Statuz { get; set; } = null!;

    public string? Extras { get; set; }

    public string? TransType { get; set; }

    public string AccountId { get; set; } = null!;

    public decimal? Charge { get; set; }

    public string? Tsrc { get; set; }
}
