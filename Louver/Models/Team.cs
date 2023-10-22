using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Team
{
    public int Id { get; set; }

    public string? TeamName { get; set; }

    public string? TeamType { get; set; }

    public int? ClientFileId { get; set; }

    public virtual ICollection<ClientFileTeam> ClientFileTeams { get; set; } = new List<ClientFileTeam>();

    public virtual ICollection<UsersTeam> UsersTeams { get; set; } = new List<UsersTeam>();
}
