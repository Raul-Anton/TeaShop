using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Order;
using TeaShop.Core.DTO.User;

namespace TeaShop.Core.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDTO_Id>().ReverseMap();
            CreateMap<User, UserDTO_Id>().ReverseMap();
            CreateMap<Address, UserAddressDTO_Id>().ReverseMap();

            CreateMap<Order, OrderDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Address, UserAddressDTO>().ReverseMap();
        }
    }
}
