using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class LinkageCode
{
    public int LinkageCodeId { get; set; }

    public string? LinkageCodeText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual ICollection<LinkagesApartment> LinkagesApartments { get; set; } = new List<LinkagesApartment>();
}
