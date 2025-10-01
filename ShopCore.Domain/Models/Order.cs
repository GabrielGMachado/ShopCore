using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models;

public class Order : Entity
{
    public OrderStatus Status { get; private set; }
    public decimal Total { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public Guid UserId { get; private set; }
    public Guid AddressId { get; private set; }

    public User User { get; private set; }
    public Address Address { get; private set; }
    public ICollection<OrderItem> OrderItems { get; private set; }
}
