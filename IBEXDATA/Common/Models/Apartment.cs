using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Apartment
{
    public int ApartmentId { get; set; }

    public int? BuildingId { get; set; }

    public int ApartmentStatus { get; set; }

    public int ApartmentNumberByContract { get; set; }

    public double? ApartmentSurfaceByContract { get; set; }

    public int? ApartmentNumberByAddress { get; set; }

    public bool? IsDetachedApartment { get; set; }

    public bool IsCompanyHasCompletedCommitments { get; set; }

    public bool IsGivenPossessionOfTheApartment { get; set; }

    public bool IsProducedLease { get; set; }

    public string? Note { get; set; }

    public DateOnly? PurchasDate { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public int? Floor { get; set; }

    public int? ApartmentOrShop { get; set; }

    public int? NumberOfLease { get; set; }

    public string? AddressByContract { get; set; }

    public string? NoteEdit { get; set; }

    public bool? NoteEditStatus { get; set; }

    public string? FloorString { get; set; }

    public string? HakiraFileName { get; set; }

    public string? NumberOfLeaseString { get; set; }

    public virtual Building? Building { get; set; }

    public virtual ICollection<LinkagesApartment> LinkagesApartments { get; set; } = new List<LinkagesApartment>();

    public virtual ICollection<Parking> Parkings { get; set; } = new List<Parking>();

    public virtual ICollection<PermissionsToAction> PermissionsToActions { get; set; } = new List<PermissionsToAction>();
}
