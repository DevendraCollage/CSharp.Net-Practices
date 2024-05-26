using System;

/*
 * Author - Devendra Parmar
 * Program - Compute the sum of two given integers, if two values are equal then return the triple of their sum
 */

namespace SumOfTwoNumber
{
    internal class Program
    {
        // Make an function to calculate the sum of the two integers
        static int calculateSum(int n1, int n2)
        {
            if (n1 == n2)
            {
                return n1 + n2;
            }
            else
            {
                return (n1 + n2) * 3;
            }
        }
        static void Main(string[] args)
        {
            // Get the two integers from the user
            Console.Write("Enter the number one here : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number two here : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the function and pass the number to the function
            Console.WriteLine(calculateSum(num1, num2));
        }
    }
}
