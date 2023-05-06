using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Reminder
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public int? Pk { get; set; }

    public int? TypeId { get; set; }

    public string? Notes { get; set; }

    public int? EndDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? ProjectId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Description { get; set; }

    public string? DescriptionAr { get; set; }

    public int? UserId { get; set; }

    public int? IsDismissed { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }
}
