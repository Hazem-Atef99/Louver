using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientShortageDetail
{
    public int ClientShortageId { get; set; }

    public int? ClientFileId { get; set; }

    public int DetailId { get; set; }

    public string? InternalColor { get; set; }

    public string? SubColor { get; set; }

    public string? TarkeebBy { get; set; }

    public string? Bayan { get; set; }

    public decimal? Hieght { get; set; }

    public decimal? Width { get; set; }

    public string? ItemCount { get; set; }

    public string? QshatColor { get; set; }

    public string? Notes { get; set; }

    public virtual ClientShortage? Client { get; set; }
}
