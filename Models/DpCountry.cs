using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpCountry
{
    public long Id { get; set; }

    public string? Iso { get; set; }

    public string? Iname { get; set; }

    public string? Iso3 { get; set; }

    public string? Oname { get; set; }

    public short? Phonecode { get; set; }

    public string? IsoCurrency { get; set; }

    public string? Currency { get; set; }
}
