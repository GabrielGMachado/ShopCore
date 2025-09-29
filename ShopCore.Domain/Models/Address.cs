namespace ShopCore.Domain.Models;

public class Address : Entity
{
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string Neighborhood { get; private set; }
    public string PostalCode { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public Guid UserId { get; private set; }

    public User User { get; private set; }
    public ICollection<Order> Orders { get; private set; }
}
