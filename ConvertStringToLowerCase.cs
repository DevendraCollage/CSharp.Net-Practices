using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to convert a given string into lowercase.
 */

namespace ConvertStringLowerCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the string from the user into UpperCase
            Console.Write("Enter the string you want to convert : ");
            string str = Console.ReadLine();

            // Convert that given string by user into lowercase
            string lowerStr = str.ToLower();

            // Print that string lowercase string to the console
            Console.WriteLine("Before Converting String To LowerCase : " + str);
            Console.WriteLine("After Converting String To LowerCase : " + lowerStr);
        }
    }
}
