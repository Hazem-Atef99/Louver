using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Status
{
    public int StatusId { get; set; }

    public string? DefaultDesc { get; set; }

    public int? IsDefault { get; set; }

    public int? StatusCategoryId { get; set; }

    public int? OrderId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public int? StatusCode { get; set; }

    public string? Country { get; set; }

    public string? Currency { get; set; }

    public string? CurrencyCode { get; set; }

    public int? ParentId { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    public int? VacationDays { get; set; }

    public int? Size { get; set; }

    public int? ItemCategoryId { get; set; }

    public decimal? Price { get; set; }

    public string? Description { get; set; }

    public int? CategoryId { get; set; }

    public int? ItemTypeId { get; set; }

    public int? SubCategoryId { get; set; }

    public string? DescriptionEn { get; set; }

    public string? ImagePath { get; set; }

    public int? HasLegs { get; set; }

    public int? HasDorj { get; set; }

    public int? HasFassaleh { get; set; }

    public int? HasAcc { get; set; }

    public int? HasHand { get; set; }

    public string? HalqEquation { get; set; }

    public string? DarfehEquationWidth { get; set; }

    public string? DarfehEquation { get; set; }

    public string? MonkholEquationWidth { get; set; }

    public string? MonkholEquation { get; set; }

    public string? GlassEquationWidth { get; set; }

    public string? GlassEquation { get; set; }

    public string? AluminiumEquation { get; set; }

    public string? ApajurEquation { get; set; }

    public string? AluminiumEquationWidth { get; set; }

    public string? ApajurEquationWidth { get; set; }

    public string? HalqEquationWidth { get; set; }

    public int? DetailCount { get; set; }

    public int? IsFarez { get; set; }

    public int? IsGlass { get; set; }

    public virtual ICollection<AnClientFileItem> AnClientFileItemGrainNavigations { get; set; } = new List<AnClientFileItem>();

    public virtual ICollection<AnClientFileItem> AnClientFileItemMaterials { get; set; } = new List<AnClientFileItem>();

    public virtual ICollection<AnClientFileItem> AnClientFileItemUnits { get; set; } = new List<AnClientFileItem>();

    public virtual ICollection<Status> InverseItemCategory { get; set; } = new List<Status>();

    public virtual Status? ItemCategory { get; set; }

    public virtual StatusCategory? StatusCategory { get; set; }
}
