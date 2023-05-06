using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ItemTypePrice
{
    public int? ItemTypeId { get; set; }

    public int? ItemId { get; set; }

    public decimal? Price { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual Status? Item { get; set; }

    public virtual Status? ItemType { get; set; }
}
