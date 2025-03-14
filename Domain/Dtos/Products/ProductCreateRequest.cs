namespace Domain.Dtos.Products;

public class ProductCreateRequest
{
    public required string Name { get; set; }
    public string? Descripton { get; set; }
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public int UnitsInStock { get; set; }
    public int CategoryId { get; set; }
    public int BrandId { get; set; }
}
