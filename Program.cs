using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW2_Part5
{
    class Test
    {
        static void Main()
        {
            // Example 1: Adding a string and a char
            string str = "Hello ";
            char ch = 'A';
            var result1 = str + ch; // Concatenation
            Console.WriteLine(result1); // Output: Hello A
            Console.WriteLine(result1.GetType()); // Output: System.String

            // Example 2: Adding an int and a double
            int num = 10;
            double dbl = 5.5;
            var result2 = num + dbl; // Addition
            Console.WriteLine(result2); // Output: 15.5
            Console.WriteLine(result2.GetType()); // Output: System.Double

            // You can continue exploring other combinations as per the exercise's instructions
        }
    }

}
