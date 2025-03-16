using Domain.Entities;

namespace Domain.Dtos.Categories;

public class CategoryResponse
{
    public int Id { get; set; }
    public required string Name { get; set; }
}
