using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Design_Patterns_Creational
{
    public class ProductFactory
    {
        public IProductName getName(ProductType type)
        {
            switch(type) 
            {
                case ProductType.BlackTea:
                    return new BlackTea();

                case ProductType.GreenTea:
                    return new GreenTea();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
