using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Tenant
{
    public int TenantId { get; set; }

    public int? TenantStatus { get; set; }

    public string? TenantIdentity { get; set; }

    public int? IdentityType { get; set; }

    public string? IdentityFromCountry { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? IdFileName { get; set; }

    public bool IsSignatureByPowerOfAttorney { get; set; }

    public string? PowerOfAttorneyId { get; set; }

    public string? AddressByContract { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public bool SignedAsTrustee { get; set; }

    public int? PreviousTenantId { get; set; }

    public string? Usname { get; set; }

    public bool? ThereRrePreviousIdentifyingDetails { get; set; }

    public int? IdentityTypePrevious { get; set; }

    public string? IdentityFromCountryPrevious { get; set; }

    public string? TenantIdentityPrevious { get; set; }

    public DateOnly? PassportExpiredPrevious { get; set; }

    public string? OtherPrevious { get; set; }

    public virtual ICollection<OwnerTenant> OwnerTenants { get; set; } = new List<OwnerTenant>();

    public virtual ICollection<RightsTransferToTenant> RightsTransferToTenants { get; set; } = new List<RightsTransferToTenant>();
}
