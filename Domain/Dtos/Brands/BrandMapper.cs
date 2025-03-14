using Domain.Entities;

namespace Domain.Dtos.Brands;

public static class BrandMapper
{
    public static Brand ToBrand(this BrandCreateRequest request)
    {
        return new Brand
        {
            Name = request.Name
        };
    }

    public static Brand ToBrand(this BrandUpdateRequest request)
    {
        return new Brand
        {
            Id = request.Id,
            Name = request.Name
        };
    }

    public static BrandResponse ToBrandResponse(this Brand brand)
    {
        return new BrandResponse
        {
            Id = brand.Id,
            Name = brand.Name
        };
    }
}
