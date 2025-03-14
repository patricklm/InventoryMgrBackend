namespace Domain.Dtos.Products;

public class ProductUpdateRequest
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Descripton { get; set; }
    public decimal Price { get; set; }
    public int UnitsInStock { get; set; }
}
