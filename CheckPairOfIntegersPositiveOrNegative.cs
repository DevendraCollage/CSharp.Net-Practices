using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check a pair of integers and return true if one is negative and one is positive.
 */

namespace CheckPairOfIntegersPositiveOrNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the Two Integers from the user
            Console.Write("Input First Integer Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Integer Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Check the two integers
            if(num1<0 && num2>0) // If this condition will match then inside this block will execute
            {
                Console.WriteLine("True");
            }else // If above condition is not match then this will inside else block will execute
            {
                Console.WriteLine("Re-enter the numbers");
            }
        }
    }
}
