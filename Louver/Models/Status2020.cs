using System;
using System.Collections.Generic;

namespace Louver.Models;

public partial class Status2020
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
}
