using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFollow2
{
    public int ClientFileId { get; set; }

    public int ClientFollow2Id { get; set; }

    public DateTime? Follow2Date { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? TypeId { get; set; }

    public string? AttachmentPath { get; set; }

    public byte[]? Attachment { get; set; }
}
