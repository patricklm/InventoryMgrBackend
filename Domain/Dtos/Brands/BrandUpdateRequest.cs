using Domain.Entities;

namespace Domain.Dtos.Brands;

public class BrandUpdateRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
