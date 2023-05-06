using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientSurveyAnswer
{
    public int ClientSurveyId { get; set; }

    public int QuestionId { get; set; }

    public int? AnswerId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual QusetionAnswer? Answer { get; set; }

    public virtual ClientSurvey ClientSurvey { get; set; } = null!;

    public virtual Question Question { get; set; } = null!;
}
