using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Team
{
    public int Id { get; set; }

    public string? TeamName { get; set; }

    public string? TeamType { get; set; }

    public int? ClientFileId { get; set; }

    public virtual ClientFile? ClientFile { get; set; }

    public virtual ClientFileRelatedDate? ClientFileNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
