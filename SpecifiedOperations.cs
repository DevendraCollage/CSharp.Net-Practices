using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program to print the results of the specified operations.
 * This program will define the undemanding of the operator precedence and associativity.
 */

namespace SpecifiedOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. First Operation
            // -1 + 4 * 6
            Console.WriteLine("The Result of this operations -1 + 4 * 6 is = " + (-1 + 4 * 6)); // Output: 23

            // 2. Second Operation
            // (35 + 5) % 7
            Console.WriteLine("The Result of this operations (35 + 5) % 7 is = " + ((35 + 5) % 7)); // Output: 5

            // 3. Third Operation
            // 14 + -4 * 6 / 11
            Console.WriteLine("The Result of this operations 14 + -4 * 6 / 11 is = " + (14 + -4 * 6 / 11)); // Output: 12

            // 4. Fourth Operaton
            // 2 + 15 / 6 * 1 - 7 % 2
            Console.WriteLine("The Result of this operations 2 + 15 / 6 * 1 - 7 % 2 is = " + (2 + 15 / 6 * 1 - 7 % 2)); // Output: 3
        }
    }
}
