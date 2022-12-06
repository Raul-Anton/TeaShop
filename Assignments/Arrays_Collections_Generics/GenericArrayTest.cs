using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Arrays_Collections_Generics
{
    public class GenericArrayTest
    {
        public void Test()
        {
            var genericArray = new GenericArray<string>(5);

            // Try Set() method
            genericArray.Set(0, "a");
            genericArray.Set(1, "ab");
            genericArray.Set(2, "abc");
            genericArray.Set(3, "abcd");
            genericArray.Set(4, "abcde");

            // Try Get() method
            Console.WriteLine(genericArray.Get(2));
            Console.WriteLine(genericArray.Get(3));

            //Try Swap() method by index
            Console.WriteLine();
            Console.WriteLine(genericArray.Get(0));
            Console.WriteLine(genericArray.Get(1));

            genericArray.SwapByIndex(0, 1);

            Console.WriteLine();
            Console.WriteLine(genericArray.Get(0));
            Console.WriteLine(genericArray.Get(1));

            //Try Swap() method by value
            Console.WriteLine();
            Console.WriteLine(genericArray.Get(3));
            Console.WriteLine(genericArray.Get(4));

            genericArray.SwapByValue("abcd", "abcde");

            Console.WriteLine();
            Console.WriteLine(genericArray.Get(3));
            Console.WriteLine(genericArray.Get(4));

            //Try Swap() method by both
            Console.WriteLine();
            Console.WriteLine(genericArray.Get(0));
            Console.WriteLine(genericArray.Get(1));

            genericArray.SwapByIndexAndValue(0, "ab", 1, "a");

            Console.WriteLine();
            Console.WriteLine(genericArray.Get(0));
            Console.WriteLine(genericArray.Get(1));
        }
    }
}
