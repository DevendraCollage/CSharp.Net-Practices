using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to check if a given string contains only lowercase
 * or uppercase characters.
 */

namespace CheckTheGivenStringIsContainsLowercaseorUppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine()!;

            string lower = str.ToLower();
            string upper = str.ToUpper();

            // Check given string contains lowercase or uppercase characters
            if(str == lower || str == upper)
            {
                Console.Write(true);
            }
            else
            {
                Console.Write(false);
            }
        }
    }
}
