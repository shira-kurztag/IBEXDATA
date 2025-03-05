using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Parking
{
    public int ParkingId { get; set; }

    public double? ParkingSurfaceByContract { get; set; }

    public int? Pairing { get; set; }

    public string? ParkingType { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public int? FatherId { get; set; }

    public int? FatherIdType { get; set; }

    public string? Identity { get; set; }

    public string? Location { get; set; }

    public string? ParkingTypeOther { get; set; }

    public virtual ICollection<LnkParkingParkingType> LnkParkingParkingTypes { get; set; } = new List<LnkParkingParkingType>();

    public virtual Apartment? PairingNavigation { get; set; }
}
