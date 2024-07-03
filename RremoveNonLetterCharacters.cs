using System;
using System.Text.RegularExpressions;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to remove all non-letter
 * characters from a given string. From Wikipedia, A letter is a
 * segmental symbol of a phonemic writing system. 
 */

namespace RemoveNonLetterCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string obj = Console.ReadLine()!;

        Console.WriteLine(Regex.Replace(obj, @"[^a-zA-Z]", ""));
        }
    }
}
