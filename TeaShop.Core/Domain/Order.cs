using TeaShop.Core.Enum;

namespace TeaShop.Core.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }

        public OrderStatus orderStatus { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}
