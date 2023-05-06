using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFileDevice
{
    public int ClientFileDeviceId { get; set; }

    public int? ClientFileId { get; set; }

    public int? DeviceId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? DeviceModelId { get; set; }

    public int? Hieght { get; set; }

    public int? Width { get; set; }

    public int? Length { get; set; }

    public string? Notes { get; set; }

    public virtual ClientFile? ClientFile { get; set; }
}
