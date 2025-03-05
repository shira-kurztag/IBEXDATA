using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class LinkagesApartment
{
    public int LinkageId { get; set; }

    public int ApartmentId { get; set; }

    public int LinkageCode { get; set; }

    public int? LinkageCodeId { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public bool? IsContractSigning { get; set; }

    public string? Details { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? AnotherType { get; set; }

    public virtual Apartment Apartment { get; set; } = null!;

    public virtual LinkageCode LinkageCodeNavigation { get; set; } = null!;
}
