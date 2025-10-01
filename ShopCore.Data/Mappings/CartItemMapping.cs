using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings
{
    public class CartItemMapping : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItem");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedAt);
            builder.Property(x => x.UpdatedAt);

            builder.Property(x => x.Quantity)
                .IsRequired()
                .HasColumnType("integer");

            builder.HasOne(x => x.Cart)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.CartId);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.CartItems)
                .HasForeignKey(x => x.ProductId);
        }
    }
}
