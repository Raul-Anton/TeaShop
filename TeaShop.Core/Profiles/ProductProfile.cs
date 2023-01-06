using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.Product;
using TeaShop.Core.DTO.User;

namespace TeaShop.Core.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Image, ProductImageDTO>().ReverseMap();

            CreateMap<Product, ProductDTO_Id>().ReverseMap();
            CreateMap<Image, ProductImageDTO_Id>().ReverseMap();
        }
    }
}
