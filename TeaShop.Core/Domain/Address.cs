using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop.Core.Domain
{
    public class Address
    {
        public Guid Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
