using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShop.Core.Domain;

namespace Assignments.Design_Patterns_Creational
{
    public class BlackTea : Product, IProductName
    {
        public string getName()
        {
            return "Black Tea";
        }
    }
}
