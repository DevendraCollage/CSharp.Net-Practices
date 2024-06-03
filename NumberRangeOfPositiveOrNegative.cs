using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
 */

namespace NumRange
{
    internal class Program
    {
        // Function to check the number is between the range of -10 to 10
        static bool checkNumRange(int num1, int num2)
        {
            if(num1 > -10 && num2 < 10)
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
            // Get the two number from the user
            Console.Write("Enter the number one here : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number two here : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the function and to print the result
            Console.WriteLine(checkNumRange(num1, num2));
        }
    }
}
