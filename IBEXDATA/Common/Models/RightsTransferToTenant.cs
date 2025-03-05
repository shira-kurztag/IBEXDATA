using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class RightsTransferToTenant
{
    public int Id { get; set; }

    public int RightsTransferId { get; set; }

    public int TeanantId { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly UpdateDate { get; set; }

    public virtual RightsTransfer RightsTransfer { get; set; } = null!;

    public virtual Tenant Teanant { get; set; } = null!;
}
