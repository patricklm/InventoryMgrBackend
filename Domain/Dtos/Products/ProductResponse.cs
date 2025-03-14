namespace Domain.Dtos.Products;

public class ProductResponse
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Descripton { get; set; }
    public string? ImageUrl { get; set; }
    public decimal Price { get; set; }
    public int UnitsInStock { get; set; }
    public bool IsDiscontinued { get; set; }
}
