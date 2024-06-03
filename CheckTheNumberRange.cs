using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check two given numbers where one is less than 100 and 
 * the other is greater than 200.
*/

namespace CheckTheNumberRange
{
    internal class Program
    {
        // Function to check the number is less than 100 and other second number is less than 200
        static bool checkNum(int num1, int num2)
        {
            if(num1 < 100 && num2 > 100)
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
            Console.Write("Enter the first number (<100) : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number (>100) : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the result
            Console.WriteLine(checkNum(num1, num2));
        }
    }
}
