using System;
using System.Collections.Generic;

namespace Flexi_Biller_Back.Models;

public partial class DpUserRole
{
    public long Id { get; set; }

    public string? RoleName { get; set; }

    public string? RolePriv { get; set; }

    public string? Ownedby { get; set; }

    public string? Deleted { get; set; }

    public string? Extras { get; set; }
}
