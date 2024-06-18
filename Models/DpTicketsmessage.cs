using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpTicketsmessage
{
    public long Id { get; set; }

    public string? Ticketid { get; set; }

    public string? Messagecontent { get; set; }

    public string? Attachements { get; set; }

    public string? Extras { get; set; }
}
