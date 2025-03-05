using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class RightsApproval
{
    public int Id { get; set; }

    public int ApartmentFileId { get; set; }

    public DateOnly? DateRecivedRequestToExport { get; set; }

    public bool? ForwardedCopyOfId { get; set; }

    public bool? AllowedToReceiveRightsApproval { get; set; }

    public bool? IsPaid { get; set; }

    public bool? ReviewedPaymentOfCommonHouseRegistration { get; set; }

    public int? Status { get; set; }

    public DateOnly? InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public virtual ApartmentFile ApartmentFile { get; set; } = null!;
}
