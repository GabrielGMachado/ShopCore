using Microsoft.EntityFrameworkCore;
using ShopCore.Domain.Models;

namespace ShopCore.Data.Context;

public class ShopContext : DbContext
{
    public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().AreUnicode(false).HaveMaxLength(250);
        base.ConfigureConventions(configurationBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<ProductComment> ProductComments { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Report> Reports { get; set; }
    
}
