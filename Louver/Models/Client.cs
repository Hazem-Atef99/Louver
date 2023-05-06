using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string? ClientName { get; set; }

    public int? ClientNo { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? Tel1 { get; set; }

    public string? ClientAddress { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? RefClientId { get; set; }

    public int? ClientStatusId { get; set; }

    public virtual ICollection<ClientFile> ClientFiles { get; set; } = new List<ClientFile>();

    public virtual ICollection<ClientPayment> ClientPayments { get; set; } = new List<ClientPayment>();
}
