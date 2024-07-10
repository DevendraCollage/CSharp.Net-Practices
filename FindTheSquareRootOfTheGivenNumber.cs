using System;
using System.Linq;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to calculate the square root of a given 
 * number. Return the integer part of the result.
 */

namespace SquareRootOfTheGivenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Sqaure root of {0} => {1}", num, Math.Sqrt(num));
        }
    }
}
