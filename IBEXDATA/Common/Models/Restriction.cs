using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Restriction
{
    public int RestrictionId { get; set; }

    public DateOnly? DateRegistration { get; set; }

    public DateOnly? DateRestriction { get; set; }

    public int? RestrictionType { get; set; }

    public int? RestrictionStatus { get; set; }

    public int? OwnerId { get; set; }

    public string? Details { get; set; }

    public int? CommentType { get; set; }

    public int? CommentSubType { get; set; }

    public DateOnly? DateRecive { get; set; }

    public int? RightThoseId { get; set; }

    public bool? IsReciveZav { get; set; }

    public bool? IsReciveSource { get; set; }

    public DateOnly? ZavDate { get; set; }

    public string? ZavFile { get; set; }

    public string? ZavPurpose { get; set; }

    public string? ApotropusProperties { get; set; }

    public int? WhoWantReportId { get; set; }

    public int? MortgageSum { get; set; }

    public bool? IsSignedComitmentInSource { get; set; }

    public bool? IsSignedReciveByBankNilveh { get; set; }

    public bool? IsSignedReciveByBankLast { get; set; }

    public bool? IsSignedReciveByBankValid { get; set; }

    public bool? IsSignedReciveByBankLastContains { get; set; }

    public bool? IsPaidHa { get; set; }

    public bool? IsPaidHasum { get; set; }

    public string? PaidMemorandum { get; set; }

    public bool? IsPaidConfirmHa { get; set; }

    public bool? IsPaidConfirmHasum { get; set; }

    public DateOnly? DateReportedHa { get; set; }

    public int? NumShtarReportedHa { get; set; }

    public bool? IssuitableToFiles { get; set; }

    public bool? IsProxyNotrion { get; set; }

    public bool? IsSignedByAll { get; set; }

    public string? RequestToRecordByAllFile { get; set; }

    public bool? IsId { get; set; }

    public string? WhoWantProduce { get; set; }

    public string? ChooseCommentCause { get; set; }

    public string? MetapelProperties { get; set; }

    public string? CommunicatioProperties { get; set; }

    public bool? IsReportHatoTenants { get; set; }

    public bool? ConfirmWithConfirm { get; set; }

    public string? ConfirmWithConfirmFile { get; set; }

    public bool? IsConfirmBankToCurrentMortgage { get; set; }

    public string? ConfirmBankToCurrentMortgageFile { get; set; }

    public bool? IsPhotoBankDocuments { get; set; }

    public bool? IsPhotoBankDocumentsValid { get; set; }

    public bool? IsSignedCompany { get; set; }

    public bool? IsLawyerComitment { get; set; }

    public int? NumDays { get; set; }

    public string? LinlToSignConfirm { get; set; }

    public string? NameTakeConfirm { get; set; }

    public DateOnly? DateTakeConfirm { get; set; }

    public int? RestrictionCauseComment { get; set; }

    public string? ZavShiputiToTabu { get; set; }

    public string? AdditionalFiles { get; set; }

    public int? Bank { get; set; }

    public string? RestrictionOtherType { get; set; }

    public string? WhoWantReportOther { get; set; }

    public int? CommentForMortgageId { get; set; }

    public int? CommentForRightTransferId { get; set; }

    public string? Note { get; set; }

    public int? DeleteRestrictionId { get; set; }

    public string? DeleteRestrictionFile { get; set; }

    public bool? IsdeleteRestrictionFileSource { get; set; }

    public DateTime? DeleteConfirmDate { get; set; }

    public string? ScanConfirmFile { get; set; }

    public int? RestrictionActionId { get; set; }

    public string? ConfirmOfTenantFile { get; set; }

    public bool? IsConfirmOfTenant { get; set; }

    public bool? IsConfirmBankWithLastComitment { get; set; }

    public bool? IsPhotoApplicationForRegistrationOfAwarning { get; set; }

    public string? ResForWhom { get; set; }

    public bool? IsRestrictionRecorded { get; set; }

    public bool? IsNirshamHearatAzara { get; set; }

    public string? HakamaLerishumHzfileName { get; set; }

    public int? PreviousStatus { get; set; }

    public string? DeleteOtherText { get; set; }

    public int? RestrictionSubStatus { get; set; }

    public bool? DeleteRequestWaitToManager { get; set; }
}
