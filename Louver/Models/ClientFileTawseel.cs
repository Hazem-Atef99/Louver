using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileTawseel
{
    public int? Id { get; set; }

    public int? ClientFileId { get; set; }

    public string? PointDescription { get; set; }

    public decimal? KitchenHeight { get; set; }

    public DateTime? TarkeebDate { get; set; }

    public string? AttachementPath { get; set; }

    public byte[]? Attachment { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? Notes { get; set; }
}
