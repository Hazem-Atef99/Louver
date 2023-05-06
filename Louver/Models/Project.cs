using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? KitchenImageFile { get; set; }

    public string? KitchenPrefix { get; set; }

    public string? DoorPrefix { get; set; }

    public string? Logo { get; set; }

    public byte[]? LogoBinary { get; set; }

    public string? ValidatePeriod { get; set; }

    public string? ValidateId { get; set; }

    public string? WindowPrefix { get; set; }

    public string? ReportFile { get; set; }
}
