using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models;

public class User : Entity
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public string CPF { get; private set; }
    public string Telefone { get; private set; }
    public Permission Role { get; private set; } = Permission.Client;

    public ICollection<Address> Addresses { get; private set; }
    public Cart Cart { get; private set; }
    public ICollection<Product> Products { get; private set; }
}
