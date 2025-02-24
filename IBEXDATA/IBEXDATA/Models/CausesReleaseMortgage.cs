using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class CausesReleaseMortgage
{
    public int CausesReleaseMortgageId { get; set; }

    public string? CausesReleaseMortgageText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
