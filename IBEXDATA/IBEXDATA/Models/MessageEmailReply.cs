using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class MessageEmailReply
{
    public int MessageId { get; set; }

    public int ReplyToUserId { get; set; }
}
