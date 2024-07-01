using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program that takes a positive number and returns the nth odd number.
 */

namespace PrintGivenNumbernthOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range you want to print odd numbers : ");
            int range = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("-- Print the odd numbers of the nth --");
            int odd = 1;
            for (int i = 1; i <= range; i++)
            {
                Console.WriteLine("{0}th odd number : {1}", i, odd);
                odd += 2;
            }
        }
    }
}
