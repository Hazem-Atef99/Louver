using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientSurveyDetail
{
    public int DetailId { get; set; }

    public int ClientSurveyId { get; set; }

    public string? SurveyNotes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual ClientSurvey ClientSurvey { get; set; } = null!;
}
