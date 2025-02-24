using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class MortagegesType
{
    public int MortagegesTypeId { get; set; }

    public string? MortagegesTypeText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual ICollection<Mortagege> Mortageges { get; set; } = new List<Mortagege>();
}
