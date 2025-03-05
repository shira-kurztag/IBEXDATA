using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class LnkParkingParkingType
{
    public int Id { get; set; }

    public int? ParkingId { get; set; }

    public int? ParkingTypeId { get; set; }

    public string? UserTextForOther { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public bool? LnkStatus { get; set; }

    public virtual Parking? Parking { get; set; }

    public virtual ParkingType? ParkingType { get; set; }
}
