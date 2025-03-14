using System;
using Domain.Entities;

namespace Domain.Dtos.Products;

public static class ProductMapper
{
    public static Product ToProduct(this ProductCreateRequest r)
    {
        return new Product
        {
            Name = r.Name,
            Descripton = r.Descripton,
            Cost = r.Cost,
            Price = r.Price,
            UnitsInStock = r.UnitsInStock,
            CategoryId = r.CategoryId,
            BrandId = r.BrandId
        };
    }

    public static Product ToProduct(this ProductUpdateRequest r)
    {
        return new Product
        {
            Id = r.Id,
            Name = r.Name,
            Descripton = r.Descripton,
            Price = r.Price,
            UnitsInStock = r.UnitsInStock
        };
    }

    public static ProductResponse ToProductResponse(this Product p)
    {
        return new ProductResponse
        {
            Id = p.Id,
            Name = p.Name,
            Descripton = p.Descripton,
            ImageUrl = p.ImageUrl,
            Price = p.Price,
            UnitsInStock = p.UnitsInStock,
            IsDiscontinued = p.IsDiscontinued
        };
    }
}
