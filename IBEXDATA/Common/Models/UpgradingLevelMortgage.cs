using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class UpgradingLevelMortgage
{
    public int UpgradingLevelMortgagesId { get; set; }

    public int? MortgagesId { get; set; }

    public int? LastLevel { get; set; }

    public int? NewLevel { get; set; }

    public string? Note { get; set; }

    public string? File { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public bool? IsPaid { get; set; }

    public bool? ManagerConfirm { get; set; }

    public virtual Mortagege? Mortgages { get; set; }
}
