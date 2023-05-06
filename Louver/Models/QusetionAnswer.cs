using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class QusetionAnswer
{
    public int AnswerId { get; set; }

    public string? AnswerDesc { get; set; }

    public virtual ICollection<ClientSurveyAnswer> ClientSurveyAnswers { get; set; } = new List<ClientSurveyAnswer>();
}
