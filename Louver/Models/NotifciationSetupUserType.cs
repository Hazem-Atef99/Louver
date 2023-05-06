using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class NotifciationSetupUserType
{
    public int NotifciationSetupId { get; set; }

    public int LevelId { get; set; }

    public int UserTypeId { get; set; }

    public string? MessageFormat { get; set; }

    public string? MessageFormatAr { get; set; }
}
