using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Design_Patterns_Creational
{
    public static class DesignPatternsCreationalTest
    {
        public static void Test()
        {
            Console.WriteLine(Admin.GetInstance());

            var productFactory = new ProductFactory();

            ProductType productType= new ProductType();
            productType = ProductType.BlackTea;

            Console.WriteLine(productFactory.getName(productType));
        }
    }
}
