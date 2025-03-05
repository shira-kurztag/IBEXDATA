using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class ZipFile
{
    public int RcrdId { get; set; }

    public int BuildingId { get; set; }

    public int ApartmentId { get; set; }

    public string UniqeId { get; set; } = null!;

    public string ZipName { get; set; } = null!;

    public string NameShow { get; set; } = null!;

    public DateTime DateEnter { get; set; }
}
