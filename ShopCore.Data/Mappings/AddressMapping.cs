using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            // Name Table
            builder.ToTable("Address");

            // Id
            builder.HasKey(x => x.Id);

            //Street
            builder.Property(x => x.Street)
                .IsRequired();

            // Number
            builder.Property(x => x.Number)
                .IsRequired();

            // Neighborhood
            builder.Property(x => x.Neighborhood)
                .IsRequired();

            // Postal Code
            builder.Property(x => x.PostalCode)
                .IsRequired();

            //City 
            builder.Property(x => x.City)
                .IsRequired();

            // State
            builder.Property(x => x.State)
                .IsRequired();

            // 1:N
            builder.HasOne(x => x.User)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.UserId);
        }
    }
}
