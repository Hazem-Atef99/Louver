using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class StatusCategory
{
    public int StatusCategoryId { get; set; }

    public string? DefaultDesc { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<Status> Statuses { get; set; } = new List<Status>();
}
