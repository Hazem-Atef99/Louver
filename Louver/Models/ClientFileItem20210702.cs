using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileItem20210702
{
    public int ClientFileItemId { get; set; }

    public int ClientFileId { get; set; }

    public int? ItemId { get; set; }

    public decimal? ItemCount { get; set; }

    public decimal? ItemPrice { get; set; }

    public decimal? ItemPriceAfterDiscount { get; set; }

    public int? ItemTypeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? Width { get; set; }

    public int? Hieght { get; set; }

    public int? Length { get; set; }

    public string? Notes { get; set; }

    public int? DoorTypeId { get; set; }

    public int? Direction { get; set; }

    public int? Itemcolor { get; set; }

    public int? ItemColorId { get; set; }

    public string? AccOption { get; set; }

    public int? CategoryId { get; set; }
}
