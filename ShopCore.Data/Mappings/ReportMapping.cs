using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class ReportMapping : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.ToTable("Reports");

        builder.HasKey(r => r.Id);

        // Title -> obrigatório
        builder.Property(r => r.Title)
            .IsRequired()
            .HasMaxLength(200);

        // Description -> obrigatório
        builder.Property(r => r.Description)
            .IsRequired()
            .HasMaxLength(2000);

        // ReportType -> enum
        builder.Property(r => r.ReportType)
            .IsRequired();

        // TargetId -> obrigatório
        builder.Property(r => r.TargetId)
            .IsRequired();

        // CreatedAt
        builder.Property(r => r.CreatedAt)
            .IsRequired();

        // Relacionamento com User (1:N)
        builder.HasOne(r => r.User)
            .WithMany(u => u.Reports) // precisa ter ICollection<Report> no User
            .HasForeignKey(r => r.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
