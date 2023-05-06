﻿using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientShortageAttachment
{
    public int ClientFileAttachmentId { get; set; }

    public int ClientShortageId { get; set; }

    public string? AttachmentPath { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? Image { get; set; }

    public string? Notes { get; set; }
}
