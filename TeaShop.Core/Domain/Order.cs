namespace TeaShop.Core.Domain
{
    public class Order
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}
