using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class MessagesEmail
{
    public int Id { get; set; }

    public string MessageBody { get; set; } = null!;

    public string MessageIssue { get; set; } = null!;

    public int FrequencyId { get; set; }

    public DateTime? OtherSpecificDate { get; set; }

    public DateTime FromDateTime { get; set; }

    public DateTime? ByDateTime { get; set; }

    public int? AboutObjectId { get; set; }
}
