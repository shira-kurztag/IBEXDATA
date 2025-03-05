using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class BankCertificate
{
    public long BankCertificatesId { get; set; }

    public int? MortgageId { get; set; }

    public int? OwnerId { get; set; }

    public bool? IsDocumentApproved { get; set; }

    public string? DocumentApproved { get; set; }

    public bool? IsDocumentApprovedSource { get; set; }

    public bool? IsDocumentApprovedValid { get; set; }

    public int? BankApproved { get; set; }

    public int? Level { get; set; }
}
