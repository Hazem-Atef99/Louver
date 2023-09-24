using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class ClientFile
{
    public int ClientFileId { get; set; }

    public int? FileNo { get; set; }

    public DateTime? FileDate { get; set; }

    public DateTime? ActionByDate { get; set; }

    public int? ActionByHour { get; set; }

    public string? ClientNeed { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? ClientId { get; set; }

    public string? DeviceNotes { get; set; }

    public string? Attachment1 { get; set; }

    public string? Attachment2 { get; set; }

    public int? KitchenHeight { get; set; }

    public decimal? Discount { get; set; }

    public DateTime? TarkeebDate { get; set; }

    public int? DesignerId { get; set; }

    public DateTime? DesignerDate { get; set; }

    public int? DiscountType { get; set; }

    public int? ContractStatusId { get; set; }

    public DateTime? ContractDate { get; set; }

    public string? ProjectManager { get; set; }

    public int? Sitet { get; set; }

    public int? Structure { get; set; }

    public string? Remarks { get; set; }

    public int? FileTypeId { get; set; }

    public string? Project { get; set; }

    public string? Owner { get; set; }

    public string? Contractor { get; set; }

    public string? AttentionMr { get; set; }

    public string? ContractorTel { get; set; }

    public string? AttentionMrTel { get; set; }

    public string? InternalDoorModel { get; set; }

    public string? ExternalDoorModel { get; set; }

    public int? InternalDoorQuantity { get; set; }

    public int? ExternalDoorQuantity { get; set; }

    public string? Remarks2 { get; set; }

    public string? Measurmentid { get; set; }

    public DateTime? MeasurmentDate { get; set; }

    public int? KitchecnModelId { get; set; }

    public int? Additionaldiscount { get; set; }

    public string? AdditionalNotes { get; set; }

    public decimal? AdditionalAmount { get; set; }

    public int? PatternType { get; set; }

    public string? KitchenLocation { get; set; }

    public string? Notes { get; set; }

    public int? SalesId { get; set; }

    public string? DesignOrder { get; set; }

    public string? ContractNo { get; set; }

    public string? OfferNo { get; set; }

    public decimal? TopDiscount { get; set; }

    public int? CombinationPeriod { get; set; }

    public int? StatusId { get; set; }

    public decimal? AccessoryDiscount { get; set; }

    public string? FactoryNotes { get; set; }

    public int? FactoryConfirmId { get; set; }

    public int? DesignStatusId { get; set; }

    public string? Follow { get; set; }

    public DateTime? SentToFactoryDate { get; set; }

    public decimal? AllPrice { get; set; }

    public int? StartWeek { get; set; }

    public int? StartMonth { get; set; }

    public int? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? WindowPrefix { get; set; }

    public int? RelatedClientFileId { get; set; }

    public int? WithTax { get; set; }

    public int? FinalStatusId { get; set; }

    public string? ClientFileStatus { get; set; }

    public virtual ICollection<AnClientFileItem> AnClientFileItems { get; set; } = new List<AnClientFileItem>();

    public virtual ICollection<AnCuttingListDetail> AnCuttingListDetails { get; set; } = new List<AnCuttingListDetail>();

    public virtual Client? Client { get; set; }

    public virtual ICollection<ClientFileDetail> ClientFileDetails { get; set; } = new List<ClientFileDetail>();

    public virtual ICollection<ClientFileDevice> ClientFileDevices { get; set; } = new List<ClientFileDevice>();

    public virtual ICollection<ClientFileFollow> ClientFileFollows { get; set; } = new List<ClientFileFollow>();

    public virtual ICollection<ClientFileItem> ClientFileItems { get; set; } = new List<ClientFileItem>();

    public virtual ClientFileRelatedDate ClientFileNavigation { get; set; } = null!;

    public virtual ICollection<ClientFileProperty> ClientFileProperties { get; set; } = new List<ClientFileProperty>();

    public virtual ICollection<ClientSurvey> ClientSurveys { get; set; } = new List<ClientSurvey>();
}
