namespace ShopCore.Domain.Models;

public class CartItem : Entity
{
    public DateTime CreateAt { get; private set; } = DateTime.Now;
    public DateTime UpdateAt { get; private set; }
    public int Quantity { get; private set; }
    public Guid CartId { get; private set; }
    public Guid ProductId { get; private set; }

    public Cart Cart { get; private set; }
    public Product Product { get; private set; }
}
