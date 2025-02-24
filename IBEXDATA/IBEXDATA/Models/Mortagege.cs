using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Mortagege
{
    public int MortagegeId { get; set; }

    public int? ToTheBank { get; set; }

    public double? Amount { get; set; }

    public DateOnly? DateCommitment { get; set; }

    public int? LevelMortagege { get; set; }

    public int? ThoseRights { get; set; }

    public int? MortagegeStatus { get; set; }

    public int? MortgageSubStatus { get; set; }

    public int? AmountType { get; set; }

    public string? Note { get; set; }

    public string? NoteOrConditioning { get; set; }

    public bool IsApprovalCompany { get; set; }

    public int? DateOfCommitmentType { get; set; }

    public string? File { get; set; }

    public string? BankApprovalFile { get; set; }

    public bool IsApprovalFileSource { get; set; }

    public bool IsApprovalFileCorrect { get; set; }

    public bool IsPaidForCommitment { get; set; }

    public string? PaidForCommitmentComment { get; set; }

    public bool IsMortgageThroughTheprocessTransferring { get; set; }

    public bool IsTenantlpprovat { get; set; }

    public string? NoteTenantlpprovat { get; set; }

    public int? CauseLiberation { get; set; }

    public int? MortagegesType { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public bool IsAllTenantlpprovat { get; set; }

    public string? IrrevocableInstructionsFile { get; set; }

    public bool IsSignIrrevocableInstructionsFile { get; set; }

    public bool IsSourceIrrevocableInstructionsFile { get; set; }

    public bool IsCorrectIrrevocableInstructionsFile { get; set; }

    public string? IrrevocableInstructionsFormSeller { get; set; }

    public string? IrrevocableInstructionsFormBuyer { get; set; }

    public DateOnly? DateOfSigning { get; set; }

    public DateOnly? ExpirationDate { get; set; }

    public int OwnerId { get; set; }

    public string? ComitmentSighnedFile { get; set; }

    public string? FixCancelComitmentFile { get; set; }

    public string? FixComment { get; set; }

    public string? FixIrrevocableInstructionsFixedFile { get; set; }

    public DateTime? FixConfirmDate { get; set; }

    public bool? UpgradeIsPaid { get; set; }

    public int? UpgradeNewLevel { get; set; }

    public string? UpgradeComment { get; set; }

    public string? UpgradeFile { get; set; }

    public DateTime? UpgradeConfirmDate { get; set; }

    public int? DeleteResonId { get; set; }

    public string? DeleteResonFile { get; set; }

    public bool? DeleteFileIsSource { get; set; }

    public string? DeleteResonOther { get; set; }

    public int? ProducerLiabilityRightTransferId { get; set; }

    public int? SugAmount { get; set; }

    public int? UpdateMortgage { get; set; }

    public bool? FixIsSignedBitulHbc { get; set; }

    public string? FixNewFile { get; set; }

    public string? FixIsSignedBitulHbcfile { get; set; }

    public string? HitchayvutChtumaFile { get; set; }

    public string? FormRecivedAndConfirm { get; set; }

    public bool? IsDocumentApproved { get; set; }

    public string? DocumentApproved { get; set; }

    public int? MortgageLevelDocumentApproved { get; set; }

    public DateOnly? BuyersSignedDate { get; set; }

    public DateOnly? BuyersExpiredDate { get; set; }

    public DateOnly? SellerSignedDate { get; set; }

    public DateOnly? SellerExpiredDate { get; set; }

    public bool? IsCorrectIrrevocableInstructionsFileSeller { get; set; }

    public bool? IsCorrectIrrevocableInstructionsFileBuyer { get; set; }

    public bool? IsSourceIrrevocableInstructionsFileSeller { get; set; }

    public bool? IsSourceIrrevocableInstructionsBuyer { get; set; }

    public string? IrrevocableInstructionsFileSeller { get; set; }

    public string? IrrevocableInstructionsFileBuyer { get; set; }

    public string? OraotBiltiChozrotPdf { get; set; }

    public string? HitchayvutWordFileName { get; set; }

    public string? IrrevocableInstructionsFileBuyerPdf { get; set; }

    public string? IrrevocableInstructionsFileSellerPdf { get; set; }

    public int? OwnerStatusTakingMortgage { get; set; }

    public bool? DeleteIsRecivedDocumentFromBank { get; set; }

    public bool? DeleteIsDocFromBankValid { get; set; }

    public bool? DeleteIsDocFromBankSource { get; set; }

    public bool? DeleteIsRecivedPledgeCancel { get; set; }

    public bool? DeleteIsPledgeCancelValid { get; set; }

    public bool? NeedToRememberWriteRestriction { get; set; }

    public int? PreviousStatus { get; set; }

    public DateOnly? DeleteDate { get; set; }

    public string? AllTenantlpprovedFile { get; set; }

    public virtual CurrencyType? AmountTypeNavigation { get; set; }

    public virtual ICollection<CorrectionMortgage> CorrectionMortgages { get; set; } = new List<CorrectionMortgage>();

    public virtual MortagegesType? MortagegesTypeNavigation { get; set; }

    public virtual ICollection<UpgradingLevelMortgage> UpgradingLevelMortgages { get; set; } = new List<UpgradingLevelMortgage>();
}
