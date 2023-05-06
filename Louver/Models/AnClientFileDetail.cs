using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnClientFileDetail
{
    public int? UnitId { get; set; }

    public int DetailId { get; set; }

    public int? CuttingListCategoryId { get; set; }

    public int? Typeid { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public decimal? Length { get; set; }

    public int? CategoryId { get; set; }

    public string? Notes { get; set; }

    public int ClientFileId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? MaterialId { get; set; }

    public string? Color { get; set; }

    public decimal? Qty { get; set; }

    public int? FinalStatusId { get; set; }

    public int? GrainId { get; set; }
}
