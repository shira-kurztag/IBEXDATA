using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class PowerOfAttorneyType
{
    public int PowerOfAttorneyTypeId { get; set; }

    public string? PowerOfAttorneyTypeText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }
}
