using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpActivityx
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public string? UserData { get; set; }

    public string? UserIp { get; set; }

    public string? TimeLog { get; set; }

    public string? Action { get; set; }

    public string? Browser { get; set; }

    public string? Branch { get; set; }
}
