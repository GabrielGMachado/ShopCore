using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class ProductMapping : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired();

        builder.Property(x => x.Description)
            .IsRequired();

        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.Property(x => x.Rating);

        builder.Property(x => x.Status);

        builder.Property(x => x.StockQuantity)
            .IsRequired()
            .HasColumnType("integer");

        builder.HasOne(x => x.User)
            .WithMany(x => x.Products);

        builder.HasMany(x => x.CartItems)
            .WithOne(x => x.Product);

        builder.HasMany(x => x.ProductImages)
            .WithOne(x => x.Product);

        builder.HasMany(x => x.OrderItems)
            .WithOne(x => x.Product);

        builder.HasMany(x => x.ProductComments)
            .WithOne(x => x.Product);
    }
}
