using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpLeave
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? Branch { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Ndays { get; set; }

    public string? Department { get; set; }

    public string? DateCreated { get; set; }

    public string? Status { get; set; }

    public string? DateApproved { get; set; }

    public string? ApprovedBy { get; set; }

    public string? Commentx { get; set; }
}
