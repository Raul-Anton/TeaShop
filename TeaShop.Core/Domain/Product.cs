namespace TeaShop.Core.Domain
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }

        public Image Image { get; set; }
    }
}
