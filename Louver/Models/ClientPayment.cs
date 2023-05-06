using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientPayment
{
    public int PaymentId { get; set; }

    public int? ClientId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? PaymentDate { get; set; }

    public int? PaymentNo { get; set; }

    public int? BankId { get; set; }

    public int? BranchId { get; set; }

    public int? PaidTypeId { get; set; }

    public int? CheckNo { get; set; }

    public string? PaidFor { get; set; }

    public string? Notes { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public DateTime? CheckDate { get; set; }

    public int? SaleId { get; set; }

    public int? StatusId { get; set; }

    public virtual Client? Client { get; set; }
}
