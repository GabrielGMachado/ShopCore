using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models;

public class User : Entity
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public string CPF { get; private set; }
    public int Telefone { get; private set; }
    public Permission Role { get; private set; } = Permission.Client;

    public ICollection<Address> Address { get; private set; }
    public Cart Cart { get; private set; }
}
