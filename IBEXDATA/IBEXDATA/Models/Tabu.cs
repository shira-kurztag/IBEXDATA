using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Tabu
{
    public int TabuId { get; set; }

    public int? OwnerId { get; set; }

    public int? ApartmentId { get; set; }

    public int? IsTenantPayingForRegistration { get; set; }

    public string? TenantPayingForRegistrationOtherText { get; set; }

    public string? TenantPayingForRegistrationDetail { get; set; }

    public bool? IsMortgagePaid { get; set; }

    public string? MortgagePaidDetail { get; set; }

    public string? SubShare { get; set; }

    public double? CommonArea { get; set; }

    public string? NotarizedPoweReason { get; set; }

    public bool? IsPurchaseTax { get; set; }

    public bool? IsPurchaseTaxValid { get; set; }

    public bool? IsCapitalTax { get; set; }

    public bool? IsCapitalTaxValid { get; set; }

    public bool? IsApprovalNeededSaleTaxHas { get; set; }

    public bool? IsApprovalNeededSaleTaxValid { get; set; }

    public bool? IsMunicipalityApproval { get; set; }

    public DateOnly? IsMunicipalityApprovalValidity { get; set; }

    public bool? IsTaxApprovedTransferRights { get; set; }

    public bool? IsTaxApprovedTransferRightsSource { get; set; }

    public bool? IsTaxApprovedTransferRightsValid { get; set; }

    public string? TofesLeaseBillFile { get; set; }

    public string? TofesBakashaLeRishuBeMmi { get; set; }

    public bool? IsPartiesSigned { get; set; }

    public bool? IsSignedByMm { get; set; }

    public bool? IsMortgageBillReceived { get; set; }

    public int? IsMortgageBillReceivedFromBankId { get; set; }

    public string? IsMortgageBillReceivedSum { get; set; }

    public bool? IsMortgageBillReceivedValid { get; set; }

    public bool? IsMortgageBillReceivedSuitable { get; set; }

    public string? Explanation { get; set; }

    public bool? IsSignedFile { get; set; }

    public string? SignedFile { get; set; }

    public bool? IsMortgageBillReceived2 { get; set; }

    public int? IsMortgageBillReceivedFromBankId2 { get; set; }

    public string? IsMortgageBillReceivedSum2 { get; set; }

    public bool? IsMortgageBillReceivedValid2 { get; set; }

    public bool? IsMortgageBillReceivedSuitable2 { get; set; }

    public string? Explanation2 { get; set; }

    public bool? IsSignedFile2 { get; set; }

    public string? SignedFile2 { get; set; }

    public bool? IsRegisteredInTabu { get; set; }

    public int? RegisteredInTabuNumShtar { get; set; }

    public DateOnly? RegisteredInTabuDateRegister { get; set; }

    public string? RegisteredInTabuComments { get; set; }

    public string? RegisteredInTabuFile { get; set; }

    public string? Note { get; set; }

    public DateTime? DachuyLeyomDate { get; set; }

    public int? Status { get; set; }

    public double? HowMuchWasPaid { get; set; }

    public virtual ICollection<BillsMortgageForTabu> BillsMortgageForTabus { get; set; } = new List<BillsMortgageForTabu>();
}
