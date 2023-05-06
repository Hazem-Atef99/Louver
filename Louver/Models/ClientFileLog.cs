using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileLog
{
    public int? ClientFileId { get; set; }

    public int? DetailId { get; set; }

    public string? FromValue { get; set; }

    public string? ToValue { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Notes { get; set; }

    public int? TypeId { get; set; }
}
