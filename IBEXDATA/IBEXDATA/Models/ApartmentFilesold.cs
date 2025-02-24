using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class ApartmentFilesold
{
    public int Id { get; set; }

    public int OwnerId { get; set; }

    public string FileName { get; set; } = null!;

    public int? ApartmentFileStatus { get; set; }

    public string? FileDisplayName { get; set; }

    public int? ApartmentFileType { get; set; }

    public string? FileNamePdf { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? ObjectId { get; set; }

    public int? MangerConfirmId { get; set; }

    public DateTime? DateConfirmId { get; set; }
}
