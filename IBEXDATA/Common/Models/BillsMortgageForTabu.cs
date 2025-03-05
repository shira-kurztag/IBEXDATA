using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class BillsMortgageForTabu
{
    public int Id { get; set; }

    public int TabuId { get; set; }

    public double? Sum { get; set; }

    public int? FromBank { get; set; }

    public bool? IsValid { get; set; }

    public bool? SuitableForLiabilities { get; set; }

    public bool? IsSign { get; set; }

    public string? FileName { get; set; }

    public string? NotesAndExplanation { get; set; }

    public int Status { get; set; }

    public DateOnly? InsertDate { get; set; }

    public virtual Bank? FromBankNavigation { get; set; }

    public virtual Tabu Tabu { get; set; } = null!;
}
