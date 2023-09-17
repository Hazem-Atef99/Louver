using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnCuttingListDetail
{
    public int? ClientFileId { get; set; }

    public int DetailId { get; set; }

    public int? TypeId { get; set; }

    public int? MaterialId { get; set; }

    public string? Color1 { get; set; }

    public int? ThicknessId { get; set; }

    public int? Thickness { get; set; }

    public int? SizeId { get; set; }

    public int? Size { get; set; }

    public int? GrainId { get; set; }

    public int? Grain { get; set; }

    public int? OrderBy { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int CuttingListDetailId { get; set; }

    public virtual ClientFile? ClientFile { get; set; }

    public virtual Status? GrainNavigation { get; set; }

    public virtual Status? Material { get; set; }

    public virtual Status? SizeNavigation { get; set; }

    public virtual Status? ThicknessNavigation { get; set; }
}
