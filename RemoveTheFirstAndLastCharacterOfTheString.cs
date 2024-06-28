using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to remove the first and last elements from a given string.
 * Sample Output:
 * -------------------------------
 * Original string: PHP
 * After removing first and last elements: H
 * Original string: Python
 * After removing first and last elements: ytho
 * Original string: JavaScript
 * After removing first and last elements: avaScrip
 */

namespace RemoveTheFirstAndLastFromTheString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine()!;

            // Get the first and last character
            Console.WriteLine(str.Substring(1, str.Length - 2));
        }
    }
}
