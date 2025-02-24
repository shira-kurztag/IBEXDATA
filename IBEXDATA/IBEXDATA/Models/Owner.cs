using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public int OwnerStatus { get; set; }

    public int? ApartmentId { get; set; }

    public int? OwnerApartmentStatus { get; set; }

    public string? MailingAddress { get; set; }

    public string? DescriptionPhone1 { get; set; }

    public string? DescriptionPhone2 { get; set; }

    public string? DescriptionPhone3 { get; set; }

    public int? NumberPhone1 { get; set; }

    public int? NumberPhone2 { get; set; }

    public int? NumberPhone3 { get; set; }

    public int? Fax { get; set; }

    public string? Email { get; set; }

    public string? LawyerName { get; set; }

    public DateOnly? DeadlineForReporting { get; set; }

    public DateOnly? NoticeDate { get; set; }

    public bool IsReported { get; set; }

    public bool IsConfirmationReporting { get; set; }

    public string? ReporteFile { get; set; }

    public string? IncumbentNumber { get; set; }

    public bool IsFurthermoreLackOfApproval { get; set; }

    public bool HavePowerOfAttorney { get; set; }

    public bool IsCorrectPowerOfAttorney { get; set; }

    public string? PowerOfAttorneyFile { get; set; }

    public bool IsGivenVouchers { get; set; }

    public bool IsLegalExpensesPaid { get; set; }

    public string? PaidNote { get; set; }

    public bool IsFormSignedIrrevocableInstructions { get; set; }

    public string? SignedIrrevocableInstructionsFile { get; set; }

    public string? LeaseContractFile { get; set; }

    public string? Note2 { get; set; }

    public bool? NoteStatus { get; set; }

    public string? SecondAddress { get; set; }

    public bool IsPaidParticipationInTheCondominium { get; set; }

    public bool IsPaymentMortgageBonds { get; set; }

    public string? PaymentMortgageBondsDetails { get; set; }

    public int? Bloc { get; set; }

    public int? Smooth { get; set; }

    public int? SubSmooth { get; set; }

    public double? SpaceUnderJointDecree { get; set; }

    public bool IsHavePowerOfAttorneyNotriony { get; set; }

    public string? CausePowerOfAttorneyNotriony { get; set; }

    public bool IsLackPurchaseTaxBalance { get; set; }

    public bool IsCorrectLackPurchaseTaxBalance { get; set; }

    public bool IsLackBalanceForCapitalGainsTax { get; set; }

    public bool IsCorrectLackBalanceForCapitalGainsTax { get; set; }

    public bool IsNeedPermissionFromSalesTax { get; set; }

    public bool IsHavePermissionFromSalesTax { get; set; }

    public bool IsCorrectPermissionFromSalesTax { get; set; }

    public bool IsThereTabooMunicipalApproval { get; set; }

    public DateOnly? TabooMunicipalApprovalDate { get; set; }

    public bool IsSourceFurthermoreLackOfTaxCertificates { get; set; }

    public bool IsCorrectFurthermoreLackOfTaxCertificates { get; set; }

    public bool IsIdentityFile { get; set; }

    public string? LeaseDeed { get; set; }

    public string? ApplicationForRegistrationOfRealEstate { get; set; }

    public bool IsSignedByTheParties { get; set; }

    public bool IsSignedByTheImi { get; set; }

    public bool IsMortgageBillsReceived { get; set; }

    public int? BillsReceivedFromBank { get; set; }

    public double? AmountBills { get; set; }

    public bool IsCorrectMortgageBillsReceived { get; set; }

    public bool IsSuitableMortgageBillsReceived { get; set; }

    public string? CommentsAndExplanation { get; set; }

    public bool IsSignMortgageBillsReceived { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? AddressAccordingToContract { get; set; }

    public DateOnly? PurchaseDate { get; set; }

    public string? ReportedApproved { get; set; }

    public int? LeaseNumber { get; set; }

    public bool IsConfirmToExport { get; set; }

    public bool? IsSignedTofesHearot { get; set; }

    public bool? IsProducedHachira { get; set; }

    public string? NumberStringPhone1 { get; set; }

    public string? NumberStringPhone2 { get; set; }

    public string? NumberStringPhone3 { get; set; }

    public string? NumberStringPhone11 { get; set; }

    public string? LeaseNumberString { get; set; }

    public string? DeleteResonOther { get; set; }

    public string? FaxNumberString { get; set; }

    public string? DeleteResonFileName { get; set; }

    public DateTime? DateDelete { get; set; }

    public virtual ICollection<OwnerTenant> OwnerTenants { get; set; } = new List<OwnerTenant>();

    public virtual ICollection<Tirshomet> Tirshomets { get; set; } = new List<Tirshomet>();
}
