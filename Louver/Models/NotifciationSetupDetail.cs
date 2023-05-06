using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class NotifciationSetupDetail
{
    public int NotifciationSetupId { get; set; }

    public int LevelId { get; set; }

    public int? FromApprovalProcessId { get; set; }

    public int? ToApprovalProcessId { get; set; }

    public int? AllowEdit { get; set; }

    public int? AllowDelete { get; set; }
}
