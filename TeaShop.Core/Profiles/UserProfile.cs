using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.User.Get;
using TeaShop.Core.DTO.User.Post;

namespace TeaShop.Core.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile() 
        {
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<Address, GetUserAddressDto>().ReverseMap();

            CreateMap<User, PostUserDto>().ReverseMap();
            CreateMap<Address, PostUserAddressDto>().ReverseMap();
        }
    }
}
