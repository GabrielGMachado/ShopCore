using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(x => x.Id);

        //Name
        builder.Property(x => x.Name)
            .IsRequired();

        //Email
        builder.Property(x => x.Email)
            .IsRequired();

        builder.HasIndex(x => x.Email)
            .IsUnique();

        //Password
        builder.Property(x => x.PasswordHash)
            .IsRequired();

        //CPF (msm sendo uma api gringa decidi colocar CPF
        builder.Property(x => x.CPF)
            .IsRequired()
            .HasMaxLength(14);

        // Telefone
        builder.Property(x => x.Telefone)
            .IsRequired()
            .HasMaxLength(20);

        // Role User
        builder.Property(x => x.Role)
            .IsRequired();

        // 1:N
        builder.HasMany(x => x.Addresses)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Cascade); // Está dizendo que quando apagar o usuário,
                                               // vai deletar todos os endereços que tem relação com ele.

        // 1:1
        builder.HasOne(x => x.Cart)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Cascade);

        // 1:N
        builder.HasMany(x => x.Products)
            .WithOne(x => x.User)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
