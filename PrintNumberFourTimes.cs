using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
 */

namespace PrintNumberFourTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number from the user
            Console.Write("Enter a Digit You Want to print : ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Print user entred number four times in different styles
            // 1. Print the first time with space seprated number
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // This will break the like when the this loop breaks

            // 2. Print the second time with no space seprated number
            for (int i = 1; i <= 4 ; i++)
            {
                Console.Write(num);
            }
            Console.WriteLine(); // This will break the like when the this loop breaks

            // 3. Print the third time with space seprated number
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // This will break the like when the this loop breaks

            // 4. Print the fourth time with no space seprated number
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(num);
            }
            Console.WriteLine(); // This will break the like when the this loop breaks
        }
    }
}
