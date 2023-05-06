using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileAnalyse
{
    public int DetailId { get; set; }

    public int ClientFileiD { get; set; }

    public string? Length { get; set; }

    public string Width { get; set; } = null!;

    public string? ItemCount { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Color { get; set; }

    public int? TypeId { get; set; }

    public int? IsManual { get; set; }

    public int? IsGlass { get; set; }

    public string? Notes { get; set; }

    public int? ItemCategoryId { get; set; }
}
