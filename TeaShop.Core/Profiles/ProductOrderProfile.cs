using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;
using TeaShop.Core.DTO.ProductOrder;

namespace TeaShop.Core.Profiles
{
    public class ProductOrderProfile : Profile
    {
        public ProductOrderProfile()
        {
            CreateMap<ProductOrder, ProductOrderDTO_Id>().ReverseMap();

            CreateMap<ProductOrder, ProductOrderDTO>().ReverseMap();
        }
    }
}
