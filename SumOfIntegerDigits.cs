using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program and compute the sum of an integer's digits.
 * 
 */

namespace SumOfIntegerDigit
{
    internal class Program
    {
        // Function to calculate the sum of the digits of the given number
        public static int toCalSum(int n)
        {
            int sum = 0; // Store the sum of the digits of the number
            while(n != 0)
            {
                sum = sum + n % 10;
                n = n / 10; // Remove the last digits of the number
            }
            return sum; // Return the sum of the digits when calculated
        }
        static void Main(string[] args)
        {
            // Get the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the sum of the givn digits
            Console.WriteLine("The sum of the digits of that number " + num + " = " + toCalSum(num));
        }
    }
}
