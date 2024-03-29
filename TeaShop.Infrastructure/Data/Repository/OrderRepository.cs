﻿using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeaShop.Core.Abstract;
using TeaShop.Core.Abstract.Repository;
using TeaShop.Core.Domain;
using TeaShop.Core.Enum;

namespace TeaShop.Infrastructure.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddOrder(Order order)
        {
            _appDbContext.Orders.Add(order);
        }

        public void DeleteOrder(Guid id)
        {
            var order = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            _appDbContext.Orders.Remove(order);
        }

        public Order GetCurrentOrderOfUser(Guid UserId)
        {
            var order = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders)
                .Where(x => x.UserId == UserId)
                .Where(x => x.orderStatus == OrderStatus.InProgress)
                .FirstOrDefault();

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order;
        }

        public IEnumerable<Order> GetCurrentOrdersOfUser(Guid UserId)
        {
            var orders = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders)
                .Where(x => x.UserId == UserId);

            if (orders == null)
            {
                throw new Exception("No orders found for the user");
            }

            return orders;
        }

        public Order GetOrder(Guid id)
        {
            var order = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            if (order == null)
            {
                throw new Exception("Order not found");
            }

            return order;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders);
        }

        public void UpdateOrder(Guid id, Order order)
        {
            var o = _appDbContext.Orders.Include(a => a.User).Include(a => a.ProductOrders).SingleOrDefault(a => a.Id == id);

            o.User = order.User;
            o.orderStatus = order.orderStatus;
        }
    }
}
