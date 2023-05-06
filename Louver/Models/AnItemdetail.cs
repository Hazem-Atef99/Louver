using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnItemdetail
{
    public int? ItemId { get; set; }

    public int? DetailId { get; set; }

    public int? HandTypeId { get; set; }

    public int? CuttingListCatgeoryId { get; set; }

    public int? CategoryId { get; set; }

    public decimal? Length { get; set; }

    public decimal? Width { get; set; }

    public decimal? Quantity { get; set; }

    public virtual AnCuttingListCatgeory? CuttingListCatgeory { get; set; }

    public virtual AnCategory? HandType { get; set; }

    public virtual AnHandType? HandTypeNavigation { get; set; }
}
