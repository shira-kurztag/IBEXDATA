using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class PermissionsToAction
{
    public int Id { get; set; }

    public int Userid { get; set; }

    public int ActionId { get; set; }

    public int Status { get; set; }

    public DateOnly InsertDate { get; set; }

    public int ApartmentId { get; set; }

    public virtual Action Action { get; set; } = null!;

    public virtual Apartment Apartment { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
