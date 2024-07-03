using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to swap a two-digit number
 * and check whether the given number is greater than its swap value.
 */

namespace CheckTheSwappedNumberofTheTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Enter the number 1 : ");
            int num2 = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine();

            Console.WriteLine("Before Swapping These Numbers : ");
            Console.WriteLine("Number-1 : {0}", num1);
            Console.WriteLine("Number-2 : {0}", num2);
            Console.WriteLine();

            int digit = num1;
            num1 = num2;
            num2 = digit;

            Console.WriteLine("After Swapping These Numbers : ");
            Console.WriteLine("Number-1 : {0}", num1);
            Console.WriteLine("Number-2 : {0}", digit);
            Console.WriteLine();

            if (num1 > digit)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
