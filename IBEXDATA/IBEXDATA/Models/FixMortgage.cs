using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class FixMortgage
{
    public int FixMortgageId { get; set; }

    public int MortgagesId { get; set; }

    public string? HitchyvutWordTmp { get; set; }

    public string? HitchyvutPdftmp { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public bool? ManagerConfirm { get; set; }

    public int? Status { get; set; }

    public int? WhichFilesToFix { get; set; }
}
