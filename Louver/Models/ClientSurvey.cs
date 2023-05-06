using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientSurvey
{
    public int ClientSurveyId { get; set; }

    public DateTime? SurveyDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public string? AwardCertificate { get; set; }

    public int? ClientFileId { get; set; }

    public virtual ClientFile? ClientFile { get; set; }

    public virtual ICollection<ClientSurveyAnswer> ClientSurveyAnswers { get; set; } = new List<ClientSurveyAnswer>();

    public virtual ICollection<ClientSurveyDetail> ClientSurveyDetails { get; set; } = new List<ClientSurveyDetail>();
}
