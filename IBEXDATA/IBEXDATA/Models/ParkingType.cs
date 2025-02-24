using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class ParkingType
{
    public int ParkingTypeId { get; set; }

    public string? ParkingTypeText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual ICollection<LnkParkingParkingType> LnkParkingParkingTypes { get; set; } = new List<LnkParkingParkingType>();
}
