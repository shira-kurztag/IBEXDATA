using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class PowerOfAttorney
{
    public int Id { get; set; }

    public string? PowerOfAttorneyId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? IdFileName { get; set; }

    public int? PowerOfAttorneyType { get; set; }

    public DateOnly? FromDate { get; set; }

    public string? FileName { get; set; }

    public string? Address { get; set; }

    public string? NumberPhone { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? NumberPhone2 { get; set; }
}
