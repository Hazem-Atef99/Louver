using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileDetail
{
    public int ClientFileDetailId { get; set; }

    public int ClientFileId { get; set; }

    public int? ClientFileTypeId { get; set; }

    public int? CarkeesTypeId { get; set; }

    public int? Hieght { get; set; }

    public int? MainColorId { get; set; }

    public int? SubColorId { get; set; }

    public int? HandModelId { get; set; }

    public int? GlassTypeId { get; set; }

    public int? FasalehTypeId { get; set; }

    public int? MajlahTypeId { get; set; }

    public int? BaterryTypeId { get; set; }

    public int? BaneltypeId { get; set; }

    public int? MajlehHallId { get; set; }

    public int? TopTypeId { get; set; }

    public int? TopWidth { get; set; }

    public int? TopColorId { get; set; }

    public string? AdditionalSide { get; set; }

    public int? WaterProofHieght { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual ClientFile ClientFile { get; set; } = null!;
}
