using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpTicket
{
    public long Id { get; set; }

    public string? Ticketid { get; set; }

    public string? Shortname { get; set; }

    public string? Subject { get; set; }

    public string? Status { get; set; }

    public string? Datecreated { get; set; }

    public string? Lastupdated { get; set; }

    public string? Userid { get; set; }

    public string? Sendername { get; set; }

    public string? Emailaddress { get; set; }

    public string? Lastreplyby { get; set; }

    public string? Extras { get; set; }
}
