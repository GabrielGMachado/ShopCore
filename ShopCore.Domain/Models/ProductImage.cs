using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models;

public class ProductImage : Entity
{
    public string URL { get; private set; }
    public Status Status { get; private set; }
    public Guid ProductId { get; private set; }

    public Product Product { get; private set; }
}
