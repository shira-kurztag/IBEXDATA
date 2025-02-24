using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class CurrencyType
{
    public int CurrencyTypeId { get; set; }

    public string? CurrencyTypeText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual ICollection<Mortagege> Mortageges { get; set; } = new List<Mortagege>();
}
