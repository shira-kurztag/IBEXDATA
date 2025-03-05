using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Tirshomet
{
    public int Id { get; set; }

    public string? TirshometContent { get; set; }

    public string? TirshometFile { get; set; }

    public int ApartmentId { get; set; }

    public int? OwnerId { get; set; }

    public DateOnly? InsertDate { get; set; }

    public virtual Owner? Owner { get; set; }
}
