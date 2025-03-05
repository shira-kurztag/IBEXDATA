using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Bank
{
    public int BankId { get; set; }

    public string? BankText { get; set; }

    public DateOnly InsertDate { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public int? BankStatus { get; set; }

    public string? LastNameBank { get; set; }

    public virtual ICollection<BillsMortgageForTabu> BillsMortgageForTabus { get; set; } = new List<BillsMortgageForTabu>();
}
