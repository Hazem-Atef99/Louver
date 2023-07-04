using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnClientFileDetail
{
    public int? ClientFileitemId { get; set; }

    public int DetailId { get; set; }

    public int? TypeId { get; set; }

    public int? CatgeoryId { get; set; }

    public decimal? Width { get; set; }

    public decimal? Hieght { get; set; }

    public decimal? Length { get; set; }

    public decimal? Qty { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual AnCategory? Catgeory { get; set; }

    public virtual AnClientFileItem? ClientFileitem { get; set; }

    public virtual AnCuttingListCatgeory? Type { get; set; }
}
