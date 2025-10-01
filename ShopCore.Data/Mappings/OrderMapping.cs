using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class OrderMapping : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Order");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Status)
            .IsRequired()
            .HasConversion<string>();

        builder.Property(x => x.Total)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.CreatedAt);

        builder.HasOne(x => x.User)
            .WithMany(x => x.Orders);

        builder.HasOne(x => x.Address)
            .WithMany(x => x.Orders);

        builder.HasMany(x => x.OrderItems)
            .WithOne(x => x.Order);
    }
}
