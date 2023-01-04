using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.DTO.User.Get;

namespace TeaShop.Core.DTO.User.Post
{
    public class PostUserDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public PostUserAddressDto Address { get; set; }
    }
}
