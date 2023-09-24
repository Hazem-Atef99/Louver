using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? FullName { get; set; }

    public int? UserTypeId { get; set; }

    public string? UserNo { get; set; }

    public int? IsAdmin { get; set; }

    public string? ImageAttachement { get; set; }

    public int? StatusId { get; set; }

    public int? ProjectId { get; set; }

    public int? TeamId { get; set; }

    public virtual Team? Team { get; set; }
}
