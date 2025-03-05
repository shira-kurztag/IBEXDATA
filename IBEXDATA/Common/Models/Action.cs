using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Action
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;

    public DateOnly InsertDate { get; set; }

    public virtual ICollection<PermissionsToAction> PermissionsToActions { get; set; } = new List<PermissionsToAction>();
}
