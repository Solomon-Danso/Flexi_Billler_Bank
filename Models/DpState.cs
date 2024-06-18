using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpState
{
    public long Id { get; set; }

    public string? Iso3 { get; set; }

    public string? Scode { get; set; }

    public string? Oname { get; set; }
}
