using Domain.Entities;

namespace Domain.Dtos.Categories;

public static class CategoryMapper
{
    public static Category ToCategory(this CategoryCreateRequest request)
    {
        return new Category
        {
            Name = request.Name
        };
    }

    public static Category ToCategory(this CategoryUpdateRequest request)
    {
        return new Category
        {
            Id = request.Id,
            Name = request.Name
        };
    }

    public static CategoryResponse ToCategoryResponse(this Category category)
    {
        return new CategoryResponse
        {
            Id = category.Id,
            Name = category.Name
        };
    }
}
