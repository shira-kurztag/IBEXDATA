using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class AdminApproval
{
    public int Id { get; set; }

    public int? NameExecuteId { get; set; }

    public int? Type { get; set; }

    public string? Message { get; set; }

    public int? Status { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int? ObjectId { get; set; }

    public int? MessageType { get; set; }

    public int? OwnerId { get; set; }

    public int? ReciverId { get; set; }

    public string? DocumentToConfirm { get; set; }

    public string? Parameters { get; set; }

    public int? ApartmentId { get; set; }

    public int? ConfirmLawyerId { get; set; }

    public int? DocumentId { get; set; }

    public string? DocumentIdList { get; set; }

    public string? ShowAnswer { get; set; }
}
