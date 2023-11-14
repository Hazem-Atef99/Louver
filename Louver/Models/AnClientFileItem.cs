using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class AnClientFileItem
{
    public int ClientFileitemId { get; set; } 

    public int? ClientFileiD { get; set; }

    public int? UnitId { get; set; }

    public int? MaterialId { get; set; }

    public string? Color { get; set; }

    public int? FinalStatusId { get; set; }

    public int? Grain { get; set; }

    public string? Notes { get; set; }

    public int? CuttingListCategoryId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual ICollection<AnClientFileDetail> AnClientFileDetails { get; set; } = new List<AnClientFileDetail>();

    public virtual ClientFile? ClientFile { get; set; }

    public virtual AnCuttingListCatgeory? CuttingListCategory { get; set; }

    public virtual Status? GrainNavigation { get; set; }

    public virtual Status? Material { get; set; }

    public virtual Status? Unit { get; set; }
}
