using System;

/*
 * Author - Devendra Parmar
 * Program -  Write a C# program to check if a given positive number is a multiple of 3 or 7.
 */

namespace CheckTheNumOf3or7
{
    internal class Program
    {
        // Function to check the number is multiple of 3 or 7
        static bool checkNum(int num) // This will check the condition if number is multiple of 3 or 7
        {
            if (num % 3==0 || num % 7==0) // If Multiple then return true
            {
                return true;
            }
            else // Otherwise return false
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Get the number from the user
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the result
            Console.WriteLine(checkNum(num));
        }
    }
}
