using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to find the minimum value from two numbers given to you, represented as a string.
 */

namespace CheckStringNumberAsanNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number 1 : ");
            string num = Console.ReadLine()!;
            Console.Write("Enter the number 2 : ");
            string num2 = Console.ReadLine()!;

            // Check the greater number from the given
            if(Int32.Parse(num) > Int32.Parse(num2))
            {
                Console.WriteLine("The {0} is Greater From Among!",num);
            }
            else
            {
                Console.WriteLine("The {0} is Greater From Among!",num2);

            }
        }
    }
}
