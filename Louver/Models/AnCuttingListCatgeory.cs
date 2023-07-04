using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnCuttingListCatgeory
{
    public int CuttingListCatgeoryId { get; set; }

    public string? DefaultDescAr { get; set; }

    public string? DefaultDescEn { get; set; }

    public virtual ICollection<AnClientFileDetail> AnClientFileDetails { get; set; } = new List<AnClientFileDetail>();

    public virtual ICollection<AnClientFileItem> AnClientFileItems { get; set; } = new List<AnClientFileItem>();
}
