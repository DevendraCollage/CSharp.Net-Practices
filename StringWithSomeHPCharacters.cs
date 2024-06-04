using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if "HP" appears at the second position in a string 
 * and return the string without "HP".
 */

namespace StringWithSomeHP
{
    internal class Program
    {
        // Functoion to check the string appearance
        static string checkStr(String str)
        {
            if(str.Substring(1,2).Equals("HP")) // This will check the second postition string is match with HP then remove the HP
            {
                return str.Remove(1,2); // This will remove the first and second character of the string if condition will match
            }
            else // Otherwise not match then return string
            {
                return str; // Othwerise return whole string if condition is not match
            }
        }
        static void Main(string[] args)
        {
            // Get the string from the user
            Console.Write("Enter the string here: ");
            String str = Console.ReadLine();

            // Call the function and print the result
            Console.WriteLine(checkStr(str));
        }
    }
}
