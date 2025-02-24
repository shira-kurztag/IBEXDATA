using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class RightsTransfer
{
    public int RightsTransferId { get; set; }

    public int? RightsTransferStatus { get; set; }

    /// <summary>
    /// מעביר זכויות
    /// </summary>
    public int SourceOwnerId { get; set; }

    public int TargetOwnerId { get; set; }

    public int? TransferType { get; set; }

    public DateOnly? TransferDate { get; set; }

    public bool InheritanceOrWill { get; set; }

    public bool IsSourceInheritanceOrWill { get; set; }

    public string? InheritenceFile { get; set; }

    public string? Files { get; set; }

    public bool IsSourcePowerOfAttorney { get; set; }

    public bool IsCorrectPowerOfAttorney { get; set; }

    public bool IsPaid { get; set; }

    public string? LawyerName1 { get; set; }

    public string? LawyerFor1 { get; set; }

    public string? LawyerAddress1 { get; set; }

    public string? LawyerPhone1 { get; set; }

    public string? LawyerFax1 { get; set; }

    public string? LawyerEmail1 { get; set; }

    public string? LawyerName2 { get; set; }

    public string? LawyerFor2 { get; set; }

    public string? LawyerAddress2 { get; set; }

    public string? LawyerPhone2 { get; set; }

    public string? LawyerFax2 { get; set; }

    public string? LawyerEmail2 { get; set; }

    public bool IsMortageteBankConsent { get; set; }

    public string? MortageteBankConsentFile { get; set; }

    public bool IsEndApproval { get; set; }

    public string? EndApprovalFile { get; set; }

    public DateOnly? EndApprovalDate { get; set; }

    public bool IsTheChangeRecordedInTheTabo { get; set; }

    public bool IsIdentity { get; set; }

    public bool IsRegistrationPaid { get; set; }

    public DateOnly? TenantsSigningDate { get; set; }

    public bool IsSourceSigning { get; set; }

    public bool IsSourcePowerOfAttorneySigning { get; set; }

    public bool IsSourcePowerOfAttorneyNotrionySigning { get; set; }

    public bool IsHealthCheck { get; set; }

    public bool IsLawyerCommitmentSigning { get; set; }

    public bool IsPowerOfAttorneyForCancelSigning { get; set; }

    public bool IsMortagege { get; set; }

    public bool IsMunicipalApproval { get; set; }

    public DateOnly? MunicipalApprovalDate { get; set; }

    public int? IsLocalCommiteeApproval { get; set; }

    public int? IsLocalCouncilApproval { get; set; }

    public bool IsPurchaseTaxApproval { get; set; }

    public bool IsBettermentTaxApproval { get; set; }

    public bool IsHouseCommiteeApproval { get; set; }

    public bool IsDivorceAgreement { get; set; }

    public bool IsSourceDivorceAgreement { get; set; }

    public string? Notes { get; set; }

    public string? Details { get; set; }

    public bool? IsSignedrEcivedInSource { get; set; }

    public bool? IsSignedDepositionInSource { get; set; }

    public string? MunicipalApprovalFile { get; set; }

    public bool? LocalCouncilConfirmIsInclude { get; set; }

    public bool? LocalMoaazaConfirmIsInclude { get; set; }

    public bool? IsPlanningComment { get; set; }

    public bool? IsConfirmPurchaseTax { get; set; }

    public bool? IsSignedLandRegistry { get; set; }

    public bool? IsSignedLandRegistrySource { get; set; }

    public string? ConfirmNoticeWarning { get; set; }

    public bool? IsCommitmenLawyer { get; set; }

    public bool? ProxyToCancelNoticeWarning { get; set; }

    public bool? ProxyToCancelNoticeWarningSignedSourceRecive { get; set; }

    public bool? DivorceAgreementWithCourtOrderValid { get; set; }

    public bool? IsSourceOriginalValid { get; set; }

    public bool? IsApplicantAuthorized { get; set; }

    public int? RightsTransferSubStatus { get; set; }

    public string? ItemDeleteReason { get; set; }

    public bool? IsSignedPowerOfAttorneyInSourceBuyer { get; set; }

    public int? ApprovalLocalCommittee { get; set; }

    public int? LocalCouncilApproval { get; set; }

    public DateOnly? ApprovalLocalCommitteeDate { get; set; }

    public DateOnly? LocalCouncilApprovalDate { get; set; }

    public DateOnly? ConfirmVaadBaitDate { get; set; }

    public DateOnly? DateZav { get; set; }

    public bool? IsNeedConfirmPurchaseTax { get; set; }

    public bool? IsNeedConfirmAppreciationTax { get; set; }

    public bool? IsNeedConfirmAppreciationTaxLocal { get; set; }

    public bool? IsNeedConfirmVaadBait { get; set; }

    public int? TenantIdSeller { get; set; }

    public string? DeleteFileName { get; set; }

    public string? IsignedrEcivedInSourceFileName { get; set; }

    public string? IsConfirmAppreciationTaxFileName { get; set; }

    public string? IsSignedDepositionInSourceFileName { get; set; }

    public string? IsSignedPowerOfAttorneyInSourceBuyerFileName { get; set; }

    public string? IsTownHallConfirmFileName { get; set; }

    public string? IsSignedPowerOfAttorneyNotrionInSourceBuyerFileName { get; set; }

    public string? IsConfirmAppreciationTaxLocalFileName { get; set; }

    public string? IsConfirmVaadBaitFileName { get; set; }

    public string? ManagementAgreementFileName { get; set; }

    public bool? ManagementAgreement { get; set; }

    public virtual ICollection<RightsTransferToTenant> RightsTransferToTenants { get; set; } = new List<RightsTransferToTenant>();
}
