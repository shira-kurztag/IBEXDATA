using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IBEXDATA.Models;

public partial class dbContext : DbContext
{
    public dbContext()
    {
    }

    public dbContext(DbContextOptions<DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<AdminApproval> AdminApprovals { get; set; }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<ApartmentFile> ApartmentFiles { get; set; }

    public virtual DbSet<ApartmentFilesold> ApartmentFilesolds { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankCertificate> BankCertificates { get; set; }

    public virtual DbSet<BillsMortgageForTabu> BillsMortgageForTabus { get; set; }

    public virtual DbSet<Building> Buildings { get; set; }

    public virtual DbSet<CausesReleaseMortgage> CausesReleaseMortgages { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Contractor> Contractors { get; set; }

    public virtual DbSet<CorrectionMortgage> CorrectionMortgages { get; set; }

    public virtual DbSet<CurrencyType> CurrencyTypes { get; set; }

    public virtual DbSet<Fare> Fares { get; set; }

    public virtual DbSet<FixMortgage> FixMortgages { get; set; }

    public virtual DbSet<LinkageCode> LinkageCodes { get; set; }

    public virtual DbSet<LinkagesApartment> LinkagesApartments { get; set; }

    public virtual DbSet<LnkParkingParkingType> LnkParkingParkingTypes { get; set; }

    public virtual DbSet<MessageEmailReply> MessageEmailReplies { get; set; }

    public virtual DbSet<MessagesEmail> MessagesEmails { get; set; }

    public virtual DbSet<Mortagege> Mortageges { get; set; }

    public virtual DbSet<MortagegeLevel> MortagegeLevels { get; set; }

    public virtual DbSet<MortagegesType> MortagegesTypes { get; set; }

    public virtual DbSet<MortgageToTeanant> MortgageToTeanants { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<OwnerTenant> OwnerTenants { get; set; }

    public virtual DbSet<Parking> Parkings { get; set; }

    public virtual DbSet<ParkingType> ParkingTypes { get; set; }

    public virtual DbSet<PermissionsToAction> PermissionsToActions { get; set; }

    public virtual DbSet<PowerOfAttorney> PowerOfAttorneys { get; set; }

    public virtual DbSet<PowerOfAttorneyType> PowerOfAttorneyTypes { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Restriction> Restrictions { get; set; }

    public virtual DbSet<RestrictionToTeanant> RestrictionToTeanants { get; set; }

    public virtual DbSet<RightsApproval> RightsApprovals { get; set; }

    public virtual DbSet<RightsTransfer> RightsTransfers { get; set; }

    public virtual DbSet<RightsTransferToTenant> RightsTransferToTenants { get; set; }

    public virtual DbSet<RightsTransferType> RightsTransferTypes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Tabu> Tabus { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<Tirshomet> Tirshomets { get; set; }

    public virtual DbSet<TransferType> TransferTypes { get; set; }

    public virtual DbSet<TypeMessage> TypeMessages { get; set; }

    public virtual DbSet<UpgradingLevelMortgage> UpgradingLevelMortgages { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<ZipFile> ZipFiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=srv2\\teachers;Database=RishumitWeinAdv;Trusted_Connection=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("mbydomain\\PracticumIBEXDATA")
            .UseCollation("SQL_Latin1_General_CP1255_CI_AS");

        modelBuilder.Entity<Action>(entity =>
        {
            entity.ToTable("Action", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("insertDate");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<AdminApproval>(entity =>
        {
            entity.ToTable("AdminApproval", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentId).HasColumnName("apartmentID");
            entity.Property(e => e.ConfirmLawyerId).HasColumnName("confirmLawyerID");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("dateUpdate");
            entity.Property(e => e.DocumentId).HasColumnName("documentID");
            entity.Property(e => e.DocumentIdList).HasColumnName("documentIdList");
            entity.Property(e => e.DocumentToConfirm)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("documentToConfirm");
            entity.Property(e => e.Message)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("message");
            entity.Property(e => e.MessageType).HasColumnName("messageType");
            entity.Property(e => e.NameExecuteId).HasColumnName("nameExecuteId");
            entity.Property(e => e.ObjectId).HasColumnName("objectID");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.Parameters).HasColumnName("parameters");
            entity.Property(e => e.ReciverId).HasColumnName("reciverID");
            entity.Property(e => e.ShowAnswer).HasColumnName("Show answer");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.ToTable("Apartments", "dbo");

            entity.Property(e => e.AddressByContract).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FloorString).HasMaxLength(50);
            entity.Property(e => e.HakiraFileName).HasColumnName("hakiraFileName");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Note).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PurchasDate).HasColumnName("purchasDate");

            entity.HasOne(d => d.Building).WithMany(p => p.Apartments)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK_Apartments_Buildings");
        });

        modelBuilder.Entity<ApartmentFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ApartmentFileBackup");

            entity.ToTable("ApartmentFiles", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentFileType).HasColumnName("apartmentFileType");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.DateConfirmId)
                .HasColumnType("datetime")
                .HasColumnName("dateConfirmID");
            entity.Property(e => e.FileDisplayName)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("fileDisplayName");
            entity.Property(e => e.FileName).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FileNamePdf).HasColumnName("FileNamePDF");
            entity.Property(e => e.MangerConfirmId).HasColumnName("mangerConfirmID");
            entity.Property(e => e.ObjectId).HasColumnName("objectID");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
        });

        modelBuilder.Entity<ApartmentFilesold>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ApartmentFiles");

            entity.ToTable("ApartmentFilesold", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentFileType).HasColumnName("apartmentFileType");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("createDate");
            entity.Property(e => e.DateConfirmId)
                .HasColumnType("datetime")
                .HasColumnName("dateConfirmID");
            entity.Property(e => e.FileDisplayName)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("fileDisplayName");
            entity.Property(e => e.FileName).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FileNamePdf).HasColumnName("FileNamePDF");
            entity.Property(e => e.MangerConfirmId).HasColumnName("mangerConfirmID");
            entity.Property(e => e.ObjectId).HasColumnName("objectID");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable("Banks", "dbo");

            entity.Property(e => e.BankText).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastNameBank).HasColumnName("lastNameBank");
        });

        modelBuilder.Entity<BankCertificate>(entity =>
        {
            entity.HasKey(e => e.BankCertificatesId).HasName("PK_bankCertificates");

            entity.ToTable("BankCertificates", "dbo");

            entity.Property(e => e.BankCertificatesId).HasColumnName("bankCertificatesId");
            entity.Property(e => e.BankApproved).HasColumnName("bankApproved");
            entity.Property(e => e.DocumentApproved).HasColumnName("documentApproved");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.MortgageId).HasColumnName("mortgageId");
            entity.Property(e => e.OwnerId).HasColumnName("ownerId");
        });

        modelBuilder.Entity<BillsMortgageForTabu>(entity =>
        {
            entity.ToTable("billsMortgageForTabu", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FileName).HasColumnName("fileName");
            entity.Property(e => e.FromBank).HasColumnName("fromBank");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("insertDate");
            entity.Property(e => e.IsSign).HasColumnName("isSign");
            entity.Property(e => e.IsValid).HasColumnName("isValid");
            entity.Property(e => e.Status)
                .HasDefaultValue(1)
                .HasColumnName("status");
            entity.Property(e => e.Sum).HasColumnName("sum");
            entity.Property(e => e.TabuId).HasColumnName("tabuId");

            entity.HasOne(d => d.FromBankNavigation).WithMany(p => p.BillsMortgageForTabus)
                .HasForeignKey(d => d.FromBank)
                .HasConstraintName("FK__billsMort__fromB__278EDA44");

            entity.HasOne(d => d.Tabu).WithMany(p => p.BillsMortgageForTabus)
                .HasForeignKey(d => d.TabuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__billsMort__tabuI__269AB60B");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.ToTable("Buildings", "dbo");

            entity.Property(e => e.AddressAndNumberOfMunicipal).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.AnotherIdentification).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.BuildingNumber).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.BuildingPermitFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.DeleteReson).HasColumnName("deleteReson");
            entity.Property(e => e.FullAssetIdentificationBeforePerselasia).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Is4Form).HasColumnName("is4Form");
            entity.Property(e => e.IsPrepareWarningComment).HasColumnName("isPrepareWarningComment");
            entity.Property(e => e.IsRishumBaitMeshutaf).HasColumnName("isRishumBaitMeshutaf");
            entity.Property(e => e.IsStartingRishumBaitMeshutaf).HasColumnName("isStartingRishumBaitMeshutaf");
            entity.Property(e => e.Note).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PerselasiaFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.SmothArea).HasColumnName("smothArea");
            entity.Property(e => e._4formFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("4FormFile");

            entity.HasOne(d => d.Project).WithMany(p => p.Buildings)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK_Buildings_Projects");
        });

        modelBuilder.Entity<CausesReleaseMortgage>(entity =>
        {
            entity.ToTable("CausesReleaseMortgages", "dbo");

            entity.Property(e => e.CausesReleaseMortgageText).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.ToTable("Comments", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommentStatus).HasColumnName("commentStatus");
            entity.Property(e => e.CommentText).HasColumnName("commentText");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("dateUpdate");
            entity.Property(e => e.IsAddedToApprovalRights).HasColumnName("isAddedToApprovalRights");
            entity.Property(e => e.ObjectId).HasColumnName("objectID");
            entity.Property(e => e.PageId).HasColumnName("pageId");
        });

        modelBuilder.Entity<Contractor>(entity =>
        {
            entity.ToTable("Contractors", "dbo");

            entity.Property(e => e.Address).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.CertificateConsortium)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ContractorIdentity)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ContractorName)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ManagementName)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e._50form)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("50Form");
        });

        modelBuilder.Entity<CorrectionMortgage>(entity =>
        {
            entity.ToTable("CorrectionMortgages", "dbo");

            entity.Property(e => e.File).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Note).UseCollation("Hebrew_CI_AS");

            entity.HasOne(d => d.Mortgage).WithMany(p => p.CorrectionMortgages)
                .HasForeignKey(d => d.MortgageId)
                .HasConstraintName("FK_CorrectionMortgages_Mortageges");
        });

        modelBuilder.Entity<CurrencyType>(entity =>
        {
            entity.ToTable("CurrencyTypes", "dbo");

            entity.Property(e => e.CurrencyTypeText).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Fare>(entity =>
        {
            entity.ToTable("Fares", "dbo");

            entity.Property(e => e.FareName).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<FixMortgage>(entity =>
        {
            entity.HasKey(e => e.FixMortgageId).HasName("fixMortgageId");

            entity.ToTable("FixMortgage", "dbo");

            entity.Property(e => e.FixMortgageId).HasColumnName("fixMortgageId");
            entity.Property(e => e.HitchyvutPdftmp).HasColumnName("hitchyvutPDFTmp");
            entity.Property(e => e.HitchyvutWordTmp).HasColumnName("hitchyvutWordTmp");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ManagerConfirm).HasColumnName("managerConfirm");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.WhichFilesToFix).HasColumnName("whichFilesToFix");
        });

        modelBuilder.Entity<LinkageCode>(entity =>
        {
            entity.ToTable("LinkageCodes", "dbo");

            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LinkageCodeText).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<LinkagesApartment>(entity =>
        {
            entity.HasKey(e => e.LinkageId).HasName("PK_LinkagesApartment1");

            entity.ToTable("LinkagesApartments", "dbo");

            entity.Property(e => e.AnotherType).HasColumnName("anotherType");
            entity.Property(e => e.Details).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Apartment).WithMany(p => p.LinkagesApartments)
                .HasForeignKey(d => d.ApartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkagesApartments_Apartments");

            entity.HasOne(d => d.LinkageCodeNavigation).WithMany(p => p.LinkagesApartments)
                .HasForeignKey(d => d.LinkageCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LinkagesApartments_LinkageCodes");
        });

        modelBuilder.Entity<LnkParkingParkingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lnk_park__3213E83F2565E92C");

            entity.ToTable("lnk_parking_parkingType", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LnkStatus).HasColumnName("lnk_status");
            entity.Property(e => e.ParkingTypeId).HasColumnName("parkingTypeId");
            entity.Property(e => e.UserTextForOther)
                .HasMaxLength(50)
                .HasColumnName("userTextForOther");

            entity.HasOne(d => d.Parking).WithMany(p => p.LnkParkingParkingTypes)
                .HasForeignKey(d => d.ParkingId)
                .HasConstraintName("FK__lnk_parki__Parki__38EE7070");

            entity.HasOne(d => d.ParkingType).WithMany(p => p.LnkParkingParkingTypes)
                .HasForeignKey(d => d.ParkingTypeId)
                .HasConstraintName("FK__lnk_parki__parki__39E294A9");
        });

        modelBuilder.Entity<MessageEmailReply>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.ReplyToUserId });

            entity.ToTable("MessageEmailReply", "dbo");

            entity.Property(e => e.MessageId).HasColumnName("messageID");
            entity.Property(e => e.ReplyToUserId).HasColumnName("replyToUserID");
        });

        modelBuilder.Entity<MessagesEmail>(entity =>
        {
            entity.ToTable("MessagesEmail", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AboutObjectId).HasColumnName("aboutObjectID");
            entity.Property(e => e.ByDateTime)
                .HasColumnType("datetime")
                .HasColumnName("byDateTime");
            entity.Property(e => e.FrequencyId).HasColumnName("frequencyID");
            entity.Property(e => e.FromDateTime)
                .HasColumnType("datetime")
                .HasColumnName("fromDateTime");
            entity.Property(e => e.MessageBody).HasColumnName("messageBody");
            entity.Property(e => e.MessageIssue).HasColumnName("messageIssue");
            entity.Property(e => e.OtherSpecificDate)
                .HasColumnType("datetime")
                .HasColumnName("other_specificDate");
        });

        modelBuilder.Entity<Mortagege>(entity =>
        {
            entity.ToTable("Mortageges", "dbo");

            entity.Property(e => e.BankApprovalFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.BuyersExpiredDate).HasColumnName("buyersExpiredDate");
            entity.Property(e => e.ComitmentSighnedFile).HasColumnName("comitmentSighnedFile");
            entity.Property(e => e.DateOfSigning).HasColumnName("dateOfSigning");
            entity.Property(e => e.DeleteDate).HasColumnName("delete_date");
            entity.Property(e => e.DeleteFileIsSource).HasColumnName("delete_FileIsSource");
            entity.Property(e => e.DeleteIsDocFromBankSource).HasColumnName("delete_isDocFromBankSource");
            entity.Property(e => e.DeleteIsDocFromBankValid).HasColumnName("delete_isDocFromBankValid");
            entity.Property(e => e.DeleteIsPledgeCancelValid).HasColumnName("delete_isPledgeCancelValid");
            entity.Property(e => e.DeleteIsRecivedDocumentFromBank).HasColumnName("delete_isRecivedDocumentFromBank");
            entity.Property(e => e.DeleteIsRecivedPledgeCancel).HasColumnName("delete_isRecivedPledgeCancel");
            entity.Property(e => e.DeleteResonFile).HasColumnName("delete_ResonFile");
            entity.Property(e => e.DeleteResonId).HasColumnName("delete_ResonId");
            entity.Property(e => e.DeleteResonOther).HasColumnName("delete_ResonOther");
            entity.Property(e => e.DocumentApproved).HasColumnName("documentApproved");
            entity.Property(e => e.ExpirationDate).HasColumnName("expirationDate");
            entity.Property(e => e.File).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FixCancelComitmentFile).HasColumnName("fix_cancelComitmentFile");
            entity.Property(e => e.FixComment).HasColumnName("fix_comment");
            entity.Property(e => e.FixConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("fix_confirmDate");
            entity.Property(e => e.FixIrrevocableInstructionsFixedFile).HasColumnName("fix_IrrevocableInstructionsFixedFile");
            entity.Property(e => e.FixIsSignedBitulHbc).HasColumnName("fix_isSignedBitulHBC");
            entity.Property(e => e.FixIsSignedBitulHbcfile).HasColumnName("fix_isSignedBitulHBCFile");
            entity.Property(e => e.FixNewFile).HasColumnName("fix_newFile");
            entity.Property(e => e.FormRecivedAndConfirm).HasColumnName("formRecivedAndConfirm");
            entity.Property(e => e.HitchayvutChtumaFile).HasColumnName("hitchayvutChtumaFile");
            entity.Property(e => e.HitchayvutWordFileName).HasColumnName("hitchayvutWordFileName");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IrrevocableInstructionsFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.IrrevocableInstructionsFileBuyerPdf).HasColumnName("IrrevocableInstructionsFileBuyerPDF");
            entity.Property(e => e.IrrevocableInstructionsFileSellerPdf).HasColumnName("IrrevocableInstructionsFileSellerPDF");
            entity.Property(e => e.IrrevocableInstructionsFormBuyer)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("irrevocableInstructionsFormBuyer");
            entity.Property(e => e.IrrevocableInstructionsFormSeller)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("irrevocableInstructionsFormSeller");
            entity.Property(e => e.MortgageLevelDocumentApproved).HasColumnName("mortgageLevelDocumentApproved");
            entity.Property(e => e.MortgageSubStatus).HasColumnName("mortgageSubStatus");
            entity.Property(e => e.NeedToRememberWriteRestriction).HasColumnName("needToRememberWriteRestriction");
            entity.Property(e => e.Note).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.NoteOrConditioning).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.NoteTenantlpprovat).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.OraotBiltiChozrotPdf).HasColumnName("oraotBiltiChozrotPDF");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.OwnerStatusTakingMortgage).HasColumnName("ownerStatusTakingMortgage");
            entity.Property(e => e.PaidForCommitmentComment)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("paidForCommitmentComment");
            entity.Property(e => e.ProducerLiabilityRightTransferId).HasColumnName("producerLiabilityRightTransferID");
            entity.Property(e => e.SellerExpiredDate).HasColumnName("sellerExpiredDate");
            entity.Property(e => e.SellerSignedDate).HasColumnName("sellerSignedDate");
            entity.Property(e => e.SugAmount).HasColumnName("sugAmount");
            entity.Property(e => e.UpdateMortgage).HasColumnName("updateMortgage");
            entity.Property(e => e.UpgradeComment).HasColumnName("upgrade_comment");
            entity.Property(e => e.UpgradeConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("upgrade_confirmDate");
            entity.Property(e => e.UpgradeFile).HasColumnName("upgrade_file");
            entity.Property(e => e.UpgradeIsPaid).HasColumnName("upgrade_isPaid");
            entity.Property(e => e.UpgradeNewLevel).HasColumnName("upgrade_newLevel");

            entity.HasOne(d => d.AmountTypeNavigation).WithMany(p => p.Mortageges)
                .HasForeignKey(d => d.AmountType)
                .HasConstraintName("FK_Mortageges_CurrencyTypes");

            entity.HasOne(d => d.MortagegesTypeNavigation).WithMany(p => p.Mortageges)
                .HasForeignKey(d => d.MortagegesType)
                .HasConstraintName("FK_Mortageges_MortagegesTypes");
        });

        modelBuilder.Entity<MortagegeLevel>(entity =>
        {
            entity.ToTable("MortagegeLevels", "dbo");

            entity.Property(e => e.MortagegeLevelText).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<MortagegesType>(entity =>
        {
            entity.ToTable("MortagegesTypes", "dbo");

            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.MortagegesTypeText).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<MortgageToTeanant>(entity =>
        {
            entity.HasKey(e => new { e.MortgageId, e.TeanantId });

            entity.ToTable("MortgageToTeanant", "dbo");

            entity.Property(e => e.MortgageId).HasColumnName("mortgageId");
            entity.Property(e => e.TeanantId).HasColumnName("teanantId");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.ToTable("Owners", "dbo");

            entity.Property(e => e.AddressAccordingToContract).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ApplicationForRegistrationOfRealEstate).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.CausePowerOfAttorneyNotriony).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.CommentsAndExplanation).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.DateDelete)
                .HasColumnType("datetime")
                .HasColumnName("dateDelete");
            entity.Property(e => e.DescriptionPhone1)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.DescriptionPhone2)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.DescriptionPhone3)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FaxNumberString)
                .HasMaxLength(50)
                .HasColumnName("faxNumberString");
            entity.Property(e => e.IncumbentNumber)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsConfirmToExport).HasColumnName("isConfirmToExport");
            entity.Property(e => e.IsProducedHachira).HasColumnName("isProducedHachira");
            entity.Property(e => e.IsSignedByTheImi).HasColumnName("IsSignedByTheIMI");
            entity.Property(e => e.IsSignedTofesHearot).HasColumnName("isSignedTofesHearot");
            entity.Property(e => e.LawyerName)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LeaseContractFile)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LeaseDeed).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.MailingAddress)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.Note2)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.NumberStringPhone1).HasMaxLength(50);
            entity.Property(e => e.NumberStringPhone2).HasMaxLength(50);
            entity.Property(e => e.NumberStringPhone3).HasMaxLength(50);
            entity.Property(e => e.PaidNote)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PaymentMortgageBondsDetails).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PowerOfAttorneyFile)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ReporteFile)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ReportedApproved).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.SecondAddress)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.SignedIrrevocableInstructionsFile)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<OwnerTenant>(entity =>
        {
            entity.HasKey(e => e.OwnerTenantsId);

            entity.ToTable("OwnerTenants", "dbo");

            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PreviuesOwnerId).HasColumnName("previuesOwnerId");

            entity.HasOne(d => d.Owner).WithMany(p => p.OwnerTenants)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OwnerTenants_Owners");

            entity.HasOne(d => d.Tenant).WithMany(p => p.OwnerTenants)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OwnerTenants_Tenants");
        });

        modelBuilder.Entity<Parking>(entity =>
        {
            entity.ToTable("parkings", "dbo");

            entity.Property(e => e.FatherId).HasColumnName("fatherId");
            entity.Property(e => e.FatherIdType).HasColumnName("fatherIdType");
            entity.Property(e => e.Identity)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("identity_");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Location)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("location");
            entity.Property(e => e.ParkingType).UseCollation("Latin1_General_CI_AS");
            entity.Property(e => e.ParkingTypeOther).HasColumnName("parkingTypeOther");

            entity.HasOne(d => d.PairingNavigation).WithMany(p => p.Parkings)
                .HasForeignKey(d => d.Pairing)
                .HasConstraintName("FK_parkings_Apartments");
        });

        modelBuilder.Entity<ParkingType>(entity =>
        {
            entity.ToTable("ParkingType", "dbo");

            entity.Property(e => e.ParkingTypeId).ValueGeneratedNever();
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ParkingTypeText).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<PermissionsToAction>(entity =>
        {
            entity.ToTable("PermissionsToAction", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId).HasColumnName("actionID");
            entity.Property(e => e.ApartmentId).HasColumnName("apartmentId");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("insertDate");
            entity.Property(e => e.Status)
                .HasDefaultValue(3)
                .HasColumnName("status");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.Action).WithMany(p => p.PermissionsToActions)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Permissio__actio__546180BB");

            entity.HasOne(d => d.Apartment).WithMany(p => p.PermissionsToActions)
                .HasForeignKey(d => d.ApartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Permissio__apart__573DED66");

            entity.HasOne(d => d.User).WithMany(p => p.PermissionsToActions)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Permissio__useri__536D5C82");
        });

        modelBuilder.Entity<PowerOfAttorney>(entity =>
        {
            entity.ToTable("PowerOfAttorneys", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FileName)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.IdFileName)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.NumberPhone)
                .HasMaxLength(150)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.NumberPhone2).HasMaxLength(150);
            entity.Property(e => e.PowerOfAttorneyId).HasMaxLength(50);
        });

        modelBuilder.Entity<PowerOfAttorneyType>(entity =>
        {
            entity.HasKey(e => e.PowerOfAttorneyTypeId).HasName("PK_PowerOfAttorneyType");

            entity.ToTable("PowerOfAttorneyTypes", "dbo");

            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.PowerOfAttorneyTypeText).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.ToTable("Projects", "dbo");

            entity.Property(e => e.AnotherIdentification).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.AppreciationTaxPaymentConfirmationFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ContractDevelopmentFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FullAssetIdentificationAfterPerselasia).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FullAssetIdentificationBeforePerselasia).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.HachiraContractEndDate).HasColumnName("hachiraContractEndDate");
            entity.Property(e => e.HachiraContractFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("hachiraContractFile");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsHachiraContract).HasColumnName("isHachiraContract");
            entity.Property(e => e.IsPrepareWarningComment).HasColumnName("isPrepareWarningComment");
            entity.Property(e => e.IsRishumBaitMeshutaf).HasColumnName("isRishumBaitMeshutaf");
            entity.Property(e => e.IsRishumBaitMeshutafStarted).HasColumnName("isRishumBaitMeshutafStarted");
            entity.Property(e => e.Neighborhood)
                .HasMaxLength(50)
                .UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.NumberHakiraContract).HasColumnName("numberHakiraContract");
            entity.Property(e => e.PerselasiaFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PowerOfAttorneyToLawyerFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ProjectName).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PurchaseTaxPaymentConfirmationFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.SalesTaxPaymentConfirmationFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.SmothArea).HasColumnName("smothArea");

            entity.HasOne(d => d.ContractingCompany).WithMany(p => p.Projects)
                .HasForeignKey(d => d.ContractingCompanyId)
                .HasConstraintName("FK_Projects_Contractors");
        });

        modelBuilder.Entity<Restriction>(entity =>
        {
            entity.ToTable("Restrictions", "dbo");

            entity.Property(e => e.AdditionalFiles)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("additionalFiles");
            entity.Property(e => e.ApotropusProperties)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("apotropusProperties");
            entity.Property(e => e.Bank).HasColumnName("bank");
            entity.Property(e => e.ChooseCommentCause)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("chooseCommentCause");
            entity.Property(e => e.CommentForMortgageId).HasColumnName("commentForMortgageID");
            entity.Property(e => e.CommentForRightTransferId).HasColumnName("commentForRightTransferId");
            entity.Property(e => e.CommentSubType).HasColumnName("commentSubType");
            entity.Property(e => e.CommentType).HasColumnName("commentType");
            entity.Property(e => e.CommunicatioProperties).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ConfirmBankToCurrentMortgageFile).HasColumnName("confirmBankToCurrentMortgageFile");
            entity.Property(e => e.ConfirmOfTenantFile).HasColumnName("confirmOfTenantFile");
            entity.Property(e => e.ConfirmWithConfirm).HasColumnName("confirmWithConfirm");
            entity.Property(e => e.ConfirmWithConfirmFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("confirmWithConfirmFile");
            entity.Property(e => e.DateReportedHa).HasColumnName("dateReportedHA");
            entity.Property(e => e.DateTakeConfirm).HasColumnName("dateTakeConfirm");
            entity.Property(e => e.DeleteConfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("deleteConfirmDate");
            entity.Property(e => e.DeleteOtherText)
                .HasMaxLength(50)
                .HasColumnName("delete_otherText");
            entity.Property(e => e.DeleteRequestWaitToManager).HasColumnName("deleteRequestWaitToManager");
            entity.Property(e => e.DeleteRestrictionFile).HasColumnName("deleteRestrictionFile");
            entity.Property(e => e.DeleteRestrictionId).HasColumnName("deleteRestrictionID");
            entity.Property(e => e.Details)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("details");
            entity.Property(e => e.HakamaLerishumHzfileName).HasColumnName("hakamaLerishumHZFileName");
            entity.Property(e => e.IsConfirmBankToCurrentMortgage).HasColumnName("isConfirmBankToCurrentMortgage");
            entity.Property(e => e.IsConfirmBankWithLastComitment).HasColumnName("isConfirmBankWithLastComitment");
            entity.Property(e => e.IsConfirmOfTenant).HasColumnName("isConfirmOfTenant");
            entity.Property(e => e.IsId).HasColumnName("isID");
            entity.Property(e => e.IsLawyerComitment).HasColumnName("isLawyerComitment");
            entity.Property(e => e.IsNirshamHearatAzara).HasColumnName("isNirshamHearatAzara");
            entity.Property(e => e.IsPaidConfirmHa).HasColumnName("isPaidConfirmHA");
            entity.Property(e => e.IsPaidConfirmHasum).HasColumnName("isPaidConfirmHASum");
            entity.Property(e => e.IsPaidHa).HasColumnName("isPaidHA");
            entity.Property(e => e.IsPaidHasum).HasColumnName("isPaidHASum");
            entity.Property(e => e.IsPhotoApplicationForRegistrationOfAwarning).HasColumnName("isPhotoApplicationForRegistrationOfAWarning");
            entity.Property(e => e.IsProxyNotrion).HasColumnName("isProxyNotrion");
            entity.Property(e => e.IsReciveSource).HasColumnName("isReciveSource");
            entity.Property(e => e.IsReciveZav).HasColumnName("isReciveZav");
            entity.Property(e => e.IsReportHatoTenants).HasColumnName("isReportHAToTenants");
            entity.Property(e => e.IsSignedByAll).HasColumnName("isSignedByAll");
            entity.Property(e => e.IsSignedComitmentInSource).HasColumnName("isSignedComitmentInSource");
            entity.Property(e => e.IsSignedCompany).HasColumnName("isSignedCompany");
            entity.Property(e => e.IsSignedReciveByBankLast).HasColumnName("isSignedReciveByBank_Last");
            entity.Property(e => e.IsSignedReciveByBankLastContains).HasColumnName("isSignedReciveByBank_LastContains");
            entity.Property(e => e.IsSignedReciveByBankNilveh).HasColumnName("isSignedReciveByBank_Nilveh");
            entity.Property(e => e.IsSignedReciveByBankValid).HasColumnName("isSignedReciveByBank_Valid");
            entity.Property(e => e.IsdeleteRestrictionFileSource).HasColumnName("isdeleteRestrictionFileSource");
            entity.Property(e => e.IssuitableToFiles).HasColumnName("issuitableToFiles");
            entity.Property(e => e.LinlToSignConfirm)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("linlToSignConfirm");
            entity.Property(e => e.MetapelProperties)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("metapelProperties");
            entity.Property(e => e.MortgageSum).HasColumnName("mortgageSum");
            entity.Property(e => e.NameTakeConfirm)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("nameTakeConfirm");
            entity.Property(e => e.NumDays).HasColumnName("numDays");
            entity.Property(e => e.NumShtarReportedHa).HasColumnName("numShtarReportedHA");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.PaidMemorandum)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("paidMemorandum");
            entity.Property(e => e.RequestToRecordByAllFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("requestToRecordByAllFile");
            entity.Property(e => e.ResForWhom).HasColumnName("resForWhom");
            entity.Property(e => e.RestrictionActionId).HasColumnName("restrictionActionID");
            entity.Property(e => e.RestrictionCauseComment).HasColumnName("restrictionCauseComment");
            entity.Property(e => e.RestrictionOtherType)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("restrictionOtherType");
            entity.Property(e => e.RightThoseId).HasColumnName("rightThoseID");
            entity.Property(e => e.ScanConfirmFile).HasColumnName("scanConfirmFile");
            entity.Property(e => e.WhoWantProduce)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("whoWantProduce");
            entity.Property(e => e.WhoWantReportId).HasColumnName("whoWantREportID");
            entity.Property(e => e.WhoWantReportOther)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("whoWantREportOther");
            entity.Property(e => e.ZavDate).HasColumnName("zavDate");
            entity.Property(e => e.ZavFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("zavFile");
            entity.Property(e => e.ZavPurpose)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("zavPurpose");
            entity.Property(e => e.ZavShiputiToTabu)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("zavShiputiToTabu");
        });

        modelBuilder.Entity<RestrictionToTeanant>(entity =>
        {
            entity.HasKey(e => new { e.RestrictionId, e.TeanantId });

            entity.ToTable("RestrictionToTeanant", "dbo");

            entity.Property(e => e.RestrictionId).HasColumnName("restrictionID");
            entity.Property(e => e.TeanantId).HasColumnName("teanantID");
        });

        modelBuilder.Entity<RightsApproval>(entity =>
        {
            entity.ToTable("RightsApproval", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentFileId).HasColumnName("apartmentFileID");
            entity.Property(e => e.ForwardedCopyOfId).HasColumnName("forwardedCopyOfID");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("insertDate");
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateDate).HasColumnName("updateDate");

            entity.HasOne(d => d.ApartmentFile).WithMany(p => p.RightsApprovals)
                .HasForeignKey(d => d.ApartmentFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RightsApp__apart__4CC05EF3");
        });

        modelBuilder.Entity<RightsTransfer>(entity =>
        {
            entity.ToTable("RightsTransfers", "dbo");

            entity.Property(e => e.ApprovalLocalCommittee).HasColumnName("approvalLocalCommittee");
            entity.Property(e => e.ApprovalLocalCommitteeDate).HasColumnName("approvalLocalCommitteeDate");
            entity.Property(e => e.ConfirmNoticeWarning).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ConfirmVaadBaitDate).HasColumnName("confirmVaadBaitDate");
            entity.Property(e => e.DateZav).HasColumnName("dateZav");
            entity.Property(e => e.DeleteFileName).HasColumnName("delete_fileName");
            entity.Property(e => e.Details).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.DivorceAgreementWithCourtOrderValid).HasColumnName("divorceAgreementWithCourtOrderValid");
            entity.Property(e => e.EndApprovalFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.Files).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InheritenceFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("inheritenceFile");
            entity.Property(e => e.IsApplicantAuthorized).HasColumnName("isApplicantAuthorized");
            entity.Property(e => e.IsCommitmenLawyer).HasColumnName("isCommitmenLawyer");
            entity.Property(e => e.IsConfirmAppreciationTaxFileName).HasColumnName("isConfirmAppreciationTaxFileName");
            entity.Property(e => e.IsConfirmAppreciationTaxLocalFileName).HasColumnName("isConfirmAppreciationTaxLocalFileName");
            entity.Property(e => e.IsConfirmPurchaseTax).HasColumnName("isConfirmPurchaseTax");
            entity.Property(e => e.IsConfirmVaadBaitFileName).HasColumnName("isConfirmVaadBaitFileName");
            entity.Property(e => e.IsNeedConfirmAppreciationTax).HasColumnName("isNeedConfirmAppreciationTax");
            entity.Property(e => e.IsNeedConfirmAppreciationTaxLocal).HasColumnName("isNeedConfirmAppreciationTaxLocal");
            entity.Property(e => e.IsNeedConfirmPurchaseTax).HasColumnName("isNeedConfirmPurchaseTax");
            entity.Property(e => e.IsNeedConfirmVaadBait).HasColumnName("isNeedConfirmVaadBait");
            entity.Property(e => e.IsPlanningComment).HasColumnName("isPlanningComment");
            entity.Property(e => e.IsSignedDepositionInSource).HasColumnName("isSignedDepositionInSource");
            entity.Property(e => e.IsSignedDepositionInSourceFileName).HasColumnName("isSignedDepositionInSourceFileName");
            entity.Property(e => e.IsSignedLandRegistry).HasColumnName("isSignedLandRegistry");
            entity.Property(e => e.IsSignedLandRegistrySource).HasColumnName("isSignedLandRegistrySource");
            entity.Property(e => e.IsSignedPowerOfAttorneyInSourceBuyer).HasColumnName("isSignedPowerOfAttorneyInSourceBuyer");
            entity.Property(e => e.IsSignedPowerOfAttorneyInSourceBuyerFileName).HasColumnName("isSignedPowerOfAttorneyInSourceBuyerFileName");
            entity.Property(e => e.IsSignedPowerOfAttorneyNotrionInSourceBuyerFileName).HasColumnName("isSignedPowerOfAttorneyNotrionInSourceBuyerFileName");
            entity.Property(e => e.IsSourceOriginalValid).HasColumnName("isSourceOriginalValid");
            entity.Property(e => e.IsTownHallConfirmFileName).HasColumnName("isTownHallConfirmFileName");
            entity.Property(e => e.IsignedrEcivedInSourceFileName).HasColumnName("ISignedrEcivedInSourceFileName");
            entity.Property(e => e.ItemDeleteReason).HasColumnName("item_deleteReason");
            entity.Property(e => e.LawyerAddress1).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerAddress2).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerEmail1).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerEmail2).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerFax1).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerFax2).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerFor1).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerFor2).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerName1).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerName2).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerPhone1).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LawyerPhone2).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.LocalCouncilApproval).HasColumnName("localCouncilApproval");
            entity.Property(e => e.LocalCouncilApprovalDate).HasColumnName("localCouncilApprovalDate");
            entity.Property(e => e.LocalCouncilConfirmIsInclude).HasColumnName("localCouncilConfirmIsInclude");
            entity.Property(e => e.LocalMoaazaConfirmIsInclude).HasColumnName("localMoaazaConfirmIsInclude");
            entity.Property(e => e.MortageteBankConsentFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.MunicipalApprovalFile).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.Notes).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.ProxyToCancelNoticeWarning).HasColumnName("proxyToCancelNoticeWarning");
            entity.Property(e => e.ProxyToCancelNoticeWarningSignedSourceRecive).HasColumnName("proxyToCancelNoticeWarningSignedSourceRecive");
            entity.Property(e => e.SourceOwnerId)
                .HasComment("מעביר זכויות")
                .HasColumnName("sourceOwnerId");
            entity.Property(e => e.TargetOwnerId).HasColumnName("targetOwnerId");
            entity.Property(e => e.TenantIdSeller).HasColumnName("tenantIdSeller");
        });

        modelBuilder.Entity<RightsTransferToTenant>(entity =>
        {
            entity.ToTable("RightsTransferToTenants", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("insertDate");
            entity.Property(e => e.TeanantId).HasColumnName("teanantId");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("updateDate");

            entity.HasOne(d => d.RightsTransfer).WithMany(p => p.RightsTransferToTenants)
                .HasForeignKey(d => d.RightsTransferId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RightsTra__Right__61BB7BD9");

            entity.HasOne(d => d.Teanant).WithMany(p => p.RightsTransferToTenants)
                .HasForeignKey(d => d.TeanantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RightsTra__teana__62AFA012");
        });

        modelBuilder.Entity<RightsTransferType>(entity =>
        {
            entity.ToTable("RightsTransferTypes", "dbo");

            entity.Property(e => e.RightsTransferTypeText).UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Roles", "dbo");

            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.Derug).HasColumnName("derug");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Tabu>(entity =>
        {
            entity.ToTable("Tabus", "dbo");

            entity.Property(e => e.TabuId).HasColumnName("TabuID");
            entity.Property(e => e.ApartmentId).HasColumnName("ApartmentID");
            entity.Property(e => e.CommonArea).HasColumnName("commonArea");
            entity.Property(e => e.DachuyLeyomDate).HasColumnType("datetime");
            entity.Property(e => e.Explanation)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("explanation");
            entity.Property(e => e.Explanation2)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("explanation2");
            entity.Property(e => e.IsApprovalNeededSaleTaxHas).HasColumnName("isApprovalNeededSaleTaxHas");
            entity.Property(e => e.IsApprovalNeededSaleTaxValid).HasColumnName("isApprovalNeededSaleTaxValid");
            entity.Property(e => e.IsCapitalTax).HasColumnName("isCapitalTax");
            entity.Property(e => e.IsCapitalTaxValid).HasColumnName("isCapitalTaxValid");
            entity.Property(e => e.IsMortgageBillReceived).HasColumnName("isMortgageBillReceived");
            entity.Property(e => e.IsMortgageBillReceived2).HasColumnName("isMortgageBillReceived2");
            entity.Property(e => e.IsMortgageBillReceivedFromBankId).HasColumnName("isMortgageBillReceivedFromBankID");
            entity.Property(e => e.IsMortgageBillReceivedFromBankId2).HasColumnName("isMortgageBillReceivedFromBankID2");
            entity.Property(e => e.IsMortgageBillReceivedSuitable).HasColumnName("isMortgageBillReceivedSuitable");
            entity.Property(e => e.IsMortgageBillReceivedSuitable2).HasColumnName("isMortgageBillReceivedSuitable2");
            entity.Property(e => e.IsMortgageBillReceivedSum)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("isMortgageBillReceivedSum");
            entity.Property(e => e.IsMortgageBillReceivedSum2)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("isMortgageBillReceivedSum2");
            entity.Property(e => e.IsMortgageBillReceivedValid).HasColumnName("isMortgageBillReceivedValid");
            entity.Property(e => e.IsMortgageBillReceivedValid2).HasColumnName("isMortgageBillReceivedValid2");
            entity.Property(e => e.IsMortgagePaid).HasColumnName("isMortgagePaid");
            entity.Property(e => e.IsMunicipalityApproval).HasColumnName("isMunicipalityApproval");
            entity.Property(e => e.IsMunicipalityApprovalValidity).HasColumnName("isMunicipalityApprovalValidity");
            entity.Property(e => e.IsPartiesSigned).HasColumnName("isPartiesSigned");
            entity.Property(e => e.IsPurchaseTax).HasColumnName("isPurchaseTax");
            entity.Property(e => e.IsPurchaseTaxValid).HasColumnName("isPurchaseTaxValid");
            entity.Property(e => e.IsRegisteredInTabu).HasColumnName("isRegisteredInTabu");
            entity.Property(e => e.IsSignedByMm).HasColumnName("isSignedByMm");
            entity.Property(e => e.IsSignedFile).HasColumnName("isSignedFile");
            entity.Property(e => e.IsSignedFile2).HasColumnName("isSignedFile2");
            entity.Property(e => e.IsTaxApprovedTransferRights).HasColumnName("isTaxApprovedTransferRights");
            entity.Property(e => e.IsTaxApprovedTransferRightsSource).HasColumnName("isTaxApprovedTransferRightsSource");
            entity.Property(e => e.IsTaxApprovedTransferRightsValid).HasColumnName("isTaxApprovedTransferRightsValid");
            entity.Property(e => e.IsTenantPayingForRegistration).HasColumnName("isTenantPayingForRegistration");
            entity.Property(e => e.MortgagePaidDetail)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("mortgagePaidDetail");
            entity.Property(e => e.NotarizedPoweReason)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("notarizedPoweReason");
            entity.Property(e => e.OwnerId).HasColumnName("ownerID");
            entity.Property(e => e.RegisteredInTabuComments)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("registeredInTabuComments");
            entity.Property(e => e.RegisteredInTabuDateRegister).HasColumnName("registeredInTabuDateRegister");
            entity.Property(e => e.RegisteredInTabuFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("registeredInTabuFile");
            entity.Property(e => e.RegisteredInTabuNumShtar).HasColumnName("registeredInTabuNumShtar");
            entity.Property(e => e.SignedFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("signedFile");
            entity.Property(e => e.SignedFile2)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("signedFile2");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.SubShare)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("subShare");
            entity.Property(e => e.TenantPayingForRegistrationDetail)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("tenantPayingForRegistrationDetail");
            entity.Property(e => e.TenantPayingForRegistrationOtherText).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.TofesBakashaLeRishuBeMmi)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("tofesBakashaLeRishuBeMmi");
            entity.Property(e => e.TofesLeaseBillFile)
                .UseCollation("Hebrew_CI_AS")
                .HasColumnName("tofesLeaseBillFile");
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.ToTable("Tenants", "dbo");

            entity.Property(e => e.AddressByContract).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.FirstName).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.IdFileName).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.IdentityFromCountry).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.IdentityFromCountryPrevious).HasColumnName("IdentityFromCountry_previous");
            entity.Property(e => e.IdentityTypePrevious).HasColumnName("IdentityType_previous");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.LastName).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.OtherPrevious).HasColumnName("other_previous");
            entity.Property(e => e.PassportExpiredPrevious).HasColumnName("passportExpired_previous");
            entity.Property(e => e.PowerOfAttorneyId).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.PreviousTenantId).HasColumnName("previousTenantId");
            entity.Property(e => e.TenantIdentity).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.TenantIdentityPrevious).HasColumnName("TenantIdentity_previous");
            entity.Property(e => e.Usname).HasColumnName("USName");
        });

        modelBuilder.Entity<Tirshomet>(entity =>
        {
            entity.ToTable("Tirshomet", "dbo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentId).HasColumnName("apartmentID");
            entity.Property(e => e.InsertDate).HasColumnName("insertDate");
            entity.Property(e => e.TirshometContent).HasColumnName("tirshomet_content");
            entity.Property(e => e.TirshometFile).HasColumnName("tirshometFile");

            entity.HasOne(d => d.Owner).WithMany(p => p.Tirshomets)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("FK_Tirshomet_Owners");
        });

        modelBuilder.Entity<TransferType>(entity =>
        {
            entity.ToTable("TransferTypes", "dbo");

            entity.Property(e => e.TransferTypeText)
                .HasMaxLength(400)
                .UseCollation("Hebrew_CI_AS");
        });

        modelBuilder.Entity<TypeMessage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TypeMessage", "dbo");

            entity.Property(e => e.TypeMessageId)
                .ValueGeneratedOnAdd()
                .HasColumnName("typeMessageId");
            entity.Property(e => e.TypeMessageName)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("typeMessageName");
        });

        modelBuilder.Entity<UpgradingLevelMortgage>(entity =>
        {
            entity.HasKey(e => e.UpgradingLevelMortgagesId);

            entity.ToTable("UpgradingLevelMortgages", "dbo");

            entity.Property(e => e.File).UseCollation("Hebrew_CI_AS");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsPaid).HasColumnName("isPaid");
            entity.Property(e => e.ManagerConfirm).HasColumnName("managerConfirm");
            entity.Property(e => e.Note).UseCollation("Hebrew_CI_AS");

            entity.HasOne(d => d.Mortgages).WithMany(p => p.UpgradingLevelMortgages)
                .HasForeignKey(d => d.MortgagesId)
                .HasConstraintName("FK_UpgradingLevelMortgages_Mortageges");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("Users", "dbo");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Email)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("email");
            entity.Property(e => e.FirstName).HasColumnName("firstName");
            entity.Property(e => e.IsMessagingSystem).HasColumnName("isMessagingSystem");
            entity.Property(e => e.LastName).HasColumnName("lastName");
            entity.Property(e => e.MembershipId).HasColumnName("membership_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UserName)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("userName");
            entity.Property(e => e.UserRole).HasColumnName("userRole");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK_Warehouse");

            entity.ToTable("Warehouses", "dbo");

            entity.Property(e => e.FloorString).HasMaxLength(50);
            entity.Property(e => e.Identity)
                .HasMaxLength(50)
                .UseCollation("Latin1_General_CI_AS")
                .HasColumnName("Identity_");
            entity.Property(e => e.InsertDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ZipFile>(entity =>
        {
            entity.HasKey(e => e.RcrdId);

            entity.ToTable("ZipFile");

            entity.Property(e => e.ApartmentId).HasColumnName("ApartmentID");
            entity.Property(e => e.DateEnter).HasColumnType("datetime");
            entity.Property(e => e.NameShow)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UniqeId)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ZipName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("zipName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
