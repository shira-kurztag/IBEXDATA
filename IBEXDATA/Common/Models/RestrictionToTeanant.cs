using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class RestrictionToTeanant
{
    public int RestrictionId { get; set; }

    public int TeanantId { get; set; }
}
