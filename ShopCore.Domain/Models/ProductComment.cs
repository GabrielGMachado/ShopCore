using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models;

public class ProductComment : Entity
{
    public double Rating { get; private set; }
    public string Title { get; private set; }
    public string? Description { get; private set; }
    public string? Image { get; private set; }
    public Status Status { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public Guid UserId { get; private set; }
    public Guid ProductId { get; private set; }

    public User User { get; private set; }
    public Product Product { get; private set; }
}
