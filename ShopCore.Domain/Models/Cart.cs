namespace ShopCore.Domain.Models;

public class Cart : Entity
{
    public Guid UserId { get; private set; }

    public User User { get; private set; }
}
