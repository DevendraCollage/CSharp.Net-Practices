using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to convert the letters of a given string (same case-upper/lower)
 * into alphabetical order.
 */

namespace ConvertTheStringinAlphabaticallyOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine()!;
            Console.WriteLine();

            // Convert to character array
            char[] charArray = str.ToArray();
            // And after that sort the character array
            Array.Sort(charArray);

            Console.WriteLine(charArray);
        }
    }
}
