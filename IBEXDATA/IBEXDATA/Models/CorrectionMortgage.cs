using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class CorrectionMortgage
{
    public int CorrectionMortgageId { get; set; }

    public int? MortgageId { get; set; }

    public string? File { get; set; }

    public bool IsApproval { get; set; }

    public string? Note { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual Mortagege? Mortgage { get; set; }
}
