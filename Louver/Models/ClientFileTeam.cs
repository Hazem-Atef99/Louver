using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileTeam
{
    public int Id { get; set; }

    public int? ClientFileId { get; set; }

    public int? TeamId { get; set; }

    public virtual ClientFile? ClientFile { get; set; }

    public virtual Team? Team { get; set; }
}
