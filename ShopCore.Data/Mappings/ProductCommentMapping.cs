using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class ProductCommentMapping : IEntityTypeConfiguration<ProductComment>
{
    public void Configure(EntityTypeBuilder<ProductComment> builder)
    {
        builder.ToTable("ProductComments");

        builder.HasKey(pc => pc.Id);

        // Rating -> double (float no banco)
        builder.Property(pc => pc.Rating)
            .IsRequired()
            .HasColumnType("float");

        // Title -> obrigatório
        builder.Property(pc => pc.Title)
            .IsRequired()
            .HasMaxLength(200);

        // Description -> opcional
        builder.Property(pc => pc.Description)
            .HasMaxLength(1000);

        // Image -> opcional
        builder.Property(pc => pc.Image)
            .HasMaxLength(500);

        // Status -> enum
        builder.Property(pc => pc.Status)
            .IsRequired();

        // CreatedAt
        builder.Property(pc => pc.CreatedAt)
            .IsRequired();

        // Relacionamento com User (1:N)
        builder.HasOne(pc => pc.User)
            .WithMany(u => u.ProductComments) 
            .HasForeignKey(pc => pc.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relacionamento com Product (1:N)
        builder.HasOne(pc => pc.Product)
            .WithMany(p => p.ProductComments) 
            .HasForeignKey(pc => pc.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
