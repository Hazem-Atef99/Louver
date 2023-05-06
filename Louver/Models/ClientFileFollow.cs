using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileFollow
{
    public int ClientFileFollowId { get; set; }

    public int ClientFileId { get; set; }

    public DateTime? NoteDate { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? LastAction { get; set; }

    public virtual ClientFile ClientFile { get; set; } = null!;
}
