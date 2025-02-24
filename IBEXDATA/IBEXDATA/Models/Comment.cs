using System;
using System.Collections.Generic;

namespace IBEXDATA.Models;

public partial class Comment
{
    public long Id { get; set; }

    public string? CommentText { get; set; }

    public bool? CommentStatus { get; set; }

    public int? PageId { get; set; }

    public bool? IsAddedToApprovalRights { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int ObjectId { get; set; }
}
