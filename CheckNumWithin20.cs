using System;

/*
 * Author - Devendra Parmar
 * Program -  Write a C# program to check if the given integer is within 20 of 100 or 200.
 */

namespace CheckNumWithin20
{
    internal class Program
    {
        // Funtion to check the given integer is within 20 of 100 or 200.
        static bool checkInt(int n)
        {
            if((n-100) <= 20 || (n-200) <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Get the integer number from the user
            Console.Write("Enter the number one here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the result
            Console.WriteLine(checkInt(num));
        }
    }
}
