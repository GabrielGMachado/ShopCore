using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class CartMapping : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Cart");

        builder.HasKey(x => x.Id);

        // 1:1
        builder.HasOne(x => x.User)
            .WithOne(x => x.Cart)
            .HasForeignKey<Cart>(x => x.UserId); // Precisa do <Cart> para ele saber em qual Entity vai ta a chave estrangeira

        // 1:N
        builder.HasMany(x => x.CartItems)
            .WithOne(x => x.Cart);
    }
}
