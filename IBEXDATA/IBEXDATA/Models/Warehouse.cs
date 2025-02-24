using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public double? WarehouseSurfaceByContract { get; set; }

    public int? Floor { get; set; }

    public int? FatherId { get; set; }

    public int? FatherIdType { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? Identity { get; set; }

    public string? FloorString { get; set; }
}
