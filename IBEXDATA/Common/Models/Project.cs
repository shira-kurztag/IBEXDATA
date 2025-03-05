using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public int? ProjectStatus { get; set; }

    public int? ContractingCompanyId { get; set; }

    public string? ProjectName { get; set; }

    public string? City { get; set; }

    public string? Neighborhood { get; set; }

    public bool IsPurchaseInTender { get; set; }

    public DateOnly? DateWinningTender { get; set; }

    public bool IsContractDevelopment { get; set; }

    public string? ContractDevelopmentFile { get; set; }

    public string? NumberLease { get; set; }

    public DateOnly? DevelopmentPeriodEndDate { get; set; }

    public bool IsDiscounted { get; set; }

    public bool IsPurchaseTaxPaymentConfirmation { get; set; }

    public string? PurchaseTaxPaymentConfirmationFile { get; set; }

    public bool IsAppreciationTaxPaymentConfirmation { get; set; }

    public string? AppreciationTaxPaymentConfirmationFile { get; set; }

    public bool? IsSalesTaxPaymentConfirmation { get; set; }

    public string? SalesTaxPaymentConfirmationFile { get; set; }

    public string? PowerOfAttorneyToLawyerFile { get; set; }

    public int? LendingBank { get; set; }

    public bool? IsPerselasia { get; set; }

    public string? FullAssetIdentificationBeforePerselasia { get; set; }

    public string? AnotherIdentification { get; set; }

    public string? PerselasiaFile { get; set; }

    public string? FullAssetIdentificationAfterPerselasia { get; set; }

    public int? Bloc { get; set; }

    public int? Smooth { get; set; }

    public bool IsTookJointListingExpenses { get; set; }

    public double? PrincipalAmount { get; set; }

    public DateOnly? CollectionExpensesFrom1 { get; set; }

    public double? CollectionAmount1 { get; set; }

    public DateOnly? CollectionExpensesFrom2 { get; set; }

    public double? CollectionAmount2 { get; set; }

    public DateOnly? CollectionExpensesFrom3 { get; set; }

    public double? CollectionAmount3 { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public bool? IsRishumBaitMeshutafStarted { get; set; }

    public bool? IsPrepareWarningComment { get; set; }

    public bool? IsRishumBaitMeshutaf { get; set; }

    public string? HachiraContractFile { get; set; }

    public string? Note { get; set; }

    public DateOnly? HachiraContractEndDate { get; set; }

    public int? LandOwnershipId { get; set; }

    public string? MechozReshutMass { get; set; }

    public string? MechozReshutMassAddress { get; set; }

    public string? MechozMenaelMekarkaey { get; set; }

    public string? MechozMenaelMekarkaeyAddress { get; set; }

    public string? MechozTabu { get; set; }

    public string? MechozTabuAddress { get; set; }

    public bool? IsDiscountedHachira { get; set; }

    public string? NumberHakiraContract { get; set; }

    public string? ProjectDrawingFile { get; set; }

    public bool? IsHachiraContract { get; set; }

    public int? SmothArea { get; set; }

    public virtual ICollection<Building> Buildings { get; set; } = new List<Building>();

    public virtual Contractor? ContractingCompany { get; set; }
}
