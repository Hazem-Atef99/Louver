using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFilePayment
{
    public int ClientFileId { get; set; }

    public int PaymentId { get; set; }

    public decimal? Amount { get; set; }

    public int? StatusId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int DetailId { get; set; }
}
