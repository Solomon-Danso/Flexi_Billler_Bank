using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpBank
{
    public int Id { get; set; }

    public string? BankName { get; set; }

    public string? BankCode { get; set; }

    public string? Isocountry { get; set; }
}
