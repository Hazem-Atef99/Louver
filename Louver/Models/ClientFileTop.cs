using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileTop
{
    public int DetailId { get; set; }

    public int ClientFileId { get; set; }

    public int? TypeId { get; set; }

    public string? TopColor { get; set; }

    public int? PanelTypeId { get; set; }

    public decimal? TopHieght { get; set; }

    public int? SinkHoleId { get; set; }

    public string? Notes { get; set; }

    public byte[]? Attachment { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }
}
