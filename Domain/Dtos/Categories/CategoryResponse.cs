using Domain.Entities;

namespace Domain.Dtos.Categories;

public class CategoryResponse
{
    public int Id { get; set; }
    public required string Name { get; set; }

    public static CategoryResponse FromCategory(Category category)
    {
        return new CategoryResponse
        {
            Id = category.Id,
            Name = category.Name
        };
    }
}
