using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to create a coded string from a given string, using a specified formula.
 * Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
 */

namespace ReplaceStringCharacterWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string word here : ");
            string word = Console.ReadLine()!;

            string modified = word.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");

            Console.WriteLine("\nThe Modified String : {0}", modified);
        }
    }
}
