namespace Domain.Entities;
public class Product
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Descripton { get; set; }
    public string? ImageUrl { get; set; }
    public decimal Cost { get; set; }
    public decimal Price { get; set; }
    public int UnitsInStock { get; set; } = 0;
    public int MinUnits { get; set; } = 10;
    public int MaxUnits { get; set; } = 50;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public int BrandId { get; set; }
    public Brand? Brand { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UPdatedAt { get; set; }
    public bool IsDiscontinued { get; set; } = false;
}
