using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Building
{
    public int BuildingId { get; set; }

    public int? ProjectId { get; set; }

    public int? BuildingStatus { get; set; }

    public string? BuildingNumber { get; set; }

    public double? FloorsNumber { get; set; }

    public bool IsElevator { get; set; }

    public string? AddressAndNumberOfMunicipal { get; set; }

    public bool IsBuildingPermit { get; set; }

    public string? BuildingPermitFile { get; set; }

    public bool Is4Form { get; set; }

    public string? _4formFile { get; set; }

    public bool IsPerselasia { get; set; }

    public string? FullAssetIdentificationBeforePerselasia { get; set; }

    public string? AnotherIdentification { get; set; }

    public string? PerselasiaFile { get; set; }

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

    public string? Note { get; set; }

    public bool NoteStatus { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? DeleteReson { get; set; }

    public string? NoteEdit { get; set; }

    public bool? NoteEditStatus { get; set; }

    public string? NoteApprovalRights { get; set; }

    public string? NoteEsitApprovalRights { get; set; }

    public string? BuildingDrawingFile { get; set; }

    public string? ParkingDrawingFile { get; set; }

    public string? WarehauseDrawingFile { get; set; }

    public string? FullAssetIdentificationAfterPerselasia { get; set; }

    public bool? IsStartingRishumBaitMeshutaf { get; set; }

    public bool? IsPrepareWarningComment { get; set; }

    public bool? IsRishumBaitMeshutaf { get; set; }

    public int? SmothArea { get; set; }

    public virtual ICollection<Apartment> Apartments { get; set; } = new List<Apartment>();

    public virtual Project? Project { get; set; }
}
