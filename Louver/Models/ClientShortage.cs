using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientShortage
{
    public int ClientFileId { get; set; }

    public int ClientShortageId { get; set; }

    public DateTime? ShortageDate { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? TarkeebDate { get; set; }

    public string? InternalColor { get; set; }

    public string? SubColor { get; set; }

    public string? TarkeebBy { get; set; }

    public virtual ICollection<ClientShortageDetail> ClientShortageDetails { get; set; } = new List<ClientShortageDetail>();
}
