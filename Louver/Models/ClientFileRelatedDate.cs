using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileRelatedDate
{
    public int ClientFileId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public DateTime? StartPaintDate { get; set; }

    public DateTime? ProductionEndDate { get; set; }

    public DateTime? ProductiorStartDate { get; set; }

    public DateTime? ProductionAnalyzeDate { get; set; }

    public virtual ClientFile? ClientFile { get; set; }

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
}
