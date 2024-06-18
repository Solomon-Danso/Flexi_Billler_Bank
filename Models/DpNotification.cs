using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpNotification
{
    public long Id { get; set; }

    public string? Type { get; set; }

    public string? Message { get; set; }

    public string? Recipient { get; set; }

    public string? Statuz { get; set; }

    public string? DateInitiated { get; set; }

    public string? DateModified { get; set; }

    public string? UserId { get; set; }

    public string? SenderId { get; set; }

    public string? Remarks { get; set; }
}
