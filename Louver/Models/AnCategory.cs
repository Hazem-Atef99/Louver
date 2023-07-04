using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnCategory
{
    public int CategoryId { get; set; }

    public string? DefaultDescAr { get; set; }

    public string? DefaultDescEn { get; set; }

    public int? TypeId { get; set; }

    public int? HasLength { get; set; }

    public int? HasWidth { get; set; }

    public int? HasHeight { get; set; }

    public int? HasCount { get; set; }

    public virtual ICollection<AnClientFileDetail> AnClientFileDetails { get; set; } = new List<AnClientFileDetail>();
}
