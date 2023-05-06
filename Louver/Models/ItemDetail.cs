using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ItemDetail
{
    public int ItemDetailId { get; set; }

    public int ItemId { get; set; }

    public int? ItemCategoryId { get; set; }

    public decimal? Lenght { get; set; }

    public string? Width { get; set; }

    public string? ItemCount { get; set; }

    public decimal? Hieght { get; set; }

    public string? Length { get; set; }

    public string? Notes { get; set; }
}
