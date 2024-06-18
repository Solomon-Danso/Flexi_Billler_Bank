using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpAdvert
{
    public long Id { get; set; }

    public string? ShortName { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Extras { get; set; }

    public string? CreatedBy { get; set; }

    public string? DateCreated { get; set; }

    public string? Statuz { get; set; }
}
