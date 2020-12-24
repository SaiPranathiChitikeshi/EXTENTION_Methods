using System;
using System.Collections.Generic;
using System.Text;
using ExtensionMethods;

namespace TestApp
{
    class ExtensionMethodSample
    {
        static void Main(string[] args)
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);
        }
    }
}
