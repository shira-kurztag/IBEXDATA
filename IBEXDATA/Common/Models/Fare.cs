using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Fare
{
    public int FareId { get; set; }

    public string? FareName { get; set; }

    public double? FareAmount { get; set; }
}
