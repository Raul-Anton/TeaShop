﻿namespace TeaShop.Core.Domain
{
    public class ProductOrder
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public Guid OrderId { get; set; }

        public Order Order { get; set; }

    }
}
