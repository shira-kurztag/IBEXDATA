using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public int? UserRole { get; set; }

    public string? Email { get; set; }

    public bool? IsMessagingSystem { get; set; }

    public bool? Status { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MembershipId { get; set; }

    public virtual ICollection<PermissionsToAction> PermissionsToActions { get; set; } = new List<PermissionsToAction>();
}
