using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Order;
using TeaShop.Core.DTO.ProductOrder;

namespace TeaShop.Core.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDTO_Id>().ReverseMap();

            CreateMap<Order, OrderDTO>().ReverseMap();

            CreateMap<Order, OrderDTO_OrderStatus>().ReverseMap();
        }
    }
}
