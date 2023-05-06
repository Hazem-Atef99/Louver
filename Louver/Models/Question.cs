using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Question
{
    public int QuestionId { get; set; }

    public string? QuestionDesc { get; set; }

    public virtual ICollection<ClientSurveyAnswer> ClientSurveyAnswers { get; set; } = new List<ClientSurveyAnswer>();
}
