using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileTopDevice
{
    public int DetailId { get; set; }

    public int ClientFileId { get; set; }

    public int Id { get; set; }

    public byte[]? Attachment { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public decimal? Width { get; set; }

    public decimal? Height { get; set; }

    public decimal? Length { get; set; }

    public string? Notes { get; set; }

    public string? AttachmentPath { get; set; }
}
