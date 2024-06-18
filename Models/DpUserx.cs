using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpUserx
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Pswd { get; set; }

    public string? Grole { get; set; }

    public string? Srole { get; set; }

    public string? Arole { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Statuz { get; set; }

    public string? ApiKey { get; set; }

    public string? LastLogin { get; set; }

    public string? AccLevel { get; set; }

    public string? Branch { get; set; }

    public string? Udobirth { get; set; }

    public string Uemail { get; set; } = null!;

    public string? Ugender { get; set; }

    public string Uphone { get; set; } = null!;

    public string? Utitle { get; set; }

    public string? DateCreated { get; set; }

    public string? DateUpdated { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? ExternalId { get; set; }

    public string? Extras { get; set; }

    public long Smsbalance { get; set; }

    public string? Ipaddress { get; set; }
}
