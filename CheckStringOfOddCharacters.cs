using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to create a string of every other character (odd position) from the first position of a given string.
 */

namespace CreateStringOfOddCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            string oddStr = String.Empty; // Initialize empty string

            // Print the string odd character of the given strings
            for (int i = 0; i < str.Length; i++)
            {
                if (i%2==0)
                {
                    oddStr = oddStr + str[i];
                }
            }

            // Print the string in an odd position
            Console.WriteLine(oddStr);
        }
    }
}
