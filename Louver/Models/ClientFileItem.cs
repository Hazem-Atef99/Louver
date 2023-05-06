using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileItem
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

    public decimal? Width { get; set; }

    public decimal? Hieght { get; set; }

    public decimal? Length { get; set; }

    public string? Notes { get; set; }

    public int? DoorTypeId { get; set; }

    public int? Direction { get; set; }

    public string? Itemcolor { get; set; }

    public int? ItemColorId { get; set; }

    public string? AccOption { get; set; }

    public int? CategoryId { get; set; }

    public int? WithAbajur { get; set; }

    public int? WithMotor { get; set; }

    public int? NoOfRoof { get; set; }

    public int? KaabTypeId { get; set; }

    public int? LenghtSection { get; set; }

    public int? WidthSection { get; set; }

    public int? DoorHole { get; set; }

    public int? Serial { get; set; }

    public byte[]? Image { get; set; }

    public string? ItemName { get; set; }

    public virtual ClientFile ClientFile { get; set; } = null!;
}
