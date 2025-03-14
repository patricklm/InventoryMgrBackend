namespace Domain.Dtos.Categories;

public class CategoryUpdateRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
