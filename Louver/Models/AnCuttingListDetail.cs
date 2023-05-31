using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnCuttingListDetail
{
    public int ClientFileId { get; set; }

    public int DetailId { get; set; }

    public int? TypeId { get; set; }

    public int? MaterialId { get; set; }

    public string? Color1 { get; set; }

    public int? Thickness { get; set; }

    public int? Size { get; set; }

    public int? Grain { get; set; }

    public int? OrderBy { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int CuttingListDetailId { get; set; }
}
