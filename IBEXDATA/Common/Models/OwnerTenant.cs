using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class OwnerTenant
{
    public int OwnerTenantsId { get; set; }

    public int OwnerId { get; set; }

    public int TenantId { get; set; }

    public double? PartAsset { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public int? PreviuesOwnerId { get; set; }

    public virtual Owner Owner { get; set; } = null!;

    public virtual Tenant Tenant { get; set; } = null!;
}
