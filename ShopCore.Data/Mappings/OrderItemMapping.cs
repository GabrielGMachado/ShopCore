using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItem");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Quantity)
            .IsRequired()
            .HasColumnType("integer");

        builder.Property(x => x.UnitPrice)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.HasOne(x => x.Product)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.ProductId);

        builder.HasOne(x => x.Order)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.OrderId);
    }
}
