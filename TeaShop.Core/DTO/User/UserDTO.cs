using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.DTO.User;

namespace TeaShop.Core.DTO.User
{
    public class UserDTO
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserAddressDTO Address { get; set; }
    }
}
