using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSC205HW2_Part5
{
    public class Test
    {
        /*
         * Create a new program named Test.cs and write a Main method that contains expres-sions
         * that combine various types using the + operator. For example, what happens
         * when you \add" a string and a char? Does it perform addition or concatenation?
         * What is the type of the result? (How can you determine the type of the result?)
         */
        public static void Main()
        {
            // Combine various types using the + operator
            int number = 10;
            double decimalNumber = 5.5;
            string str = "Hello";
            char character1 = 'A';
            bool boolValue = true;
            char character2 = 'B';

            // Adding an int and a double
            // Oerator for numeric types results in a widening conversion if necessary to fit the larger type (double in this case)
            // Output - Result of int + double: 15.5, Type: System.Double
            double result1 = number + decimalNumber;
            Console.WriteLine($"Result of int + double: {result1}, Type: {result1.GetType()}");

            // Concatenating a string and an int
            // Converts the int to a string and appends it to the string
            // Output - Result of string + int: Hello10, Type: System.String
            string result2 = str + number;
            Console.WriteLine($"Result of string + int: {result2}, Type: {result2.GetType()}");

            // Concatenating a string and a char
            // Converts the char to a string and appends it to the string
            // Output - Result of string + char: HelloA, Type: System.String
            string result3 = str + character1;
            Console.WriteLine($"Result of string + char: {result3}, Type: {result3.GetType()}");

            // Adding an int and a char
            // Converts the char to its corresponding ASCII value (because char is essentially an integer type representing Unicode characters)
            // Output - Result of int + char: 75, Type: System.Int32
            int result4 = number + character1;
            Console.WriteLine($"Result of int + char: {result4}, Type: {result4.GetType()}");

            /*
             * String concatenation: The + operator concatenates strings regardless of the other type involved.
             * Numeric addition: For numeric types (int, double, etc.), the + operator performs addition,
             * with type conversions as necessary.
             * Resulting type: You can determine the type of the result using GetType() method,
             * which gives you the actual type of the resulting value.
             */

            // Example of bool + char
            // This is illegal in C#, as the + operator is not defined for bool and char types.
            // Uncommenting the line below will result in a compile-time error.
            // Console.WriteLine(boolValue + charValue)

            // However, if you want to concatenate them into a string, you can do so:
            string result = boolValue.ToString() + character1;
            Console.WriteLine($"Result of bool + char as string: {result},  Type: {result.GetType()}");

            // Example of char + char
            // The + operator is legal for char types in C#, and it performs string concatenation.
            string result5 = character1 + character2.ToString();
            Console.WriteLine($"Result of char + char as string: {result5}, Type: {result5.GetType()}");

            char x = 'C';
            // Using x++
            x++;
            Console.WriteLine($"After x++, x is now: {x}");

            // Using x = x + 1
            // Uncommenting the line below will result in a compile-time error.
            // x = x + 1;
        }
    }

}