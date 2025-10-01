namespace ShopCore.Domain.Models;

public class CartItem : Entity
{
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
    public int Quantity { get; private set; }
    public Guid CartId { get; private set; }
    public Guid ProductId { get; private set; }

    public Cart Cart { get; private set; }
    public Product Product { get; private set; }
}
