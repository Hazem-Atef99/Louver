using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Clientmaintainance
{
    public int ClientFileId { get; set; }

    public int ClientMaintainanceId { get; set; }

    public DateTime? MaintainanceDate { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? TarkeebDate { get; set; }

    public string? Attachmentpath { get; set; }

    public byte[]? Image { get; set; }
}
