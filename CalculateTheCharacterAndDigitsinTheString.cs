using System;
using System.Data.SqlTypes;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to get the number of letters and digits in a given string.
 */

namespace CalculateTheCharAndNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine()!;

            int strCount = 0;
            int digitCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    strCount++;
                }
                else
                {
                    digitCount++;
                }
            }

            Console.WriteLine("The Character Count of the String is : {0}", strCount);
            Console.WriteLine("The Count of the digits in the String is : {0} ", digitCount); 
        }
    }
}
