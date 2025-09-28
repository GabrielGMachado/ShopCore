using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models
{
    public class Product : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public double? Rating { get; private set; }
        public Status Status { get; private set; }
        public int StockQuantity { get; private set; }
        public Guid UserId { get; private set; }

        public User User { get; private set; }
        public ICollection<CartItem> CartItems  { get; private set; }
        public ICollection<ProductImage> ProductImages { get; private set; }
        public ICollection<ProductComment> ProductComments { get; private set; }
    }
}
