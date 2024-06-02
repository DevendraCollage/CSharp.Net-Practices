using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if a string starts with a specified word.
 */

namespace StringStartsWith
{
    internal class Program
    {
        // Function to check string is startswith or not
        static bool checkStr(string str)
        {
            // Check the string is startwith or not
            if (str.StartsWith("Hello"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Get the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            // Call the function and print the answer
            Console.WriteLine(checkStr(str));
        }
    }
}
