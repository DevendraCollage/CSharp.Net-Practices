using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to create a string of four copies, taking the last four 
 * characters from a given string. If the given string is less than 4, return the original one.
 */

namespace PrintTheStringLast4Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            /* Check if the string length is less than 4 then print the original otherwise 
             * print the last 4 characters of the string 4 four times.
             * */
            int len = str.Length; // This will store the string length

            Console.WriteLine("\n");
            if(len > 4) // if chaacter length greater than 4
            {
                string lastFourChar = str.Substring(len - 4, 4); // This will store the last four digit of the string
                for (int i = 1;  i <= 4;  i++)
                {
                    Console.Write(lastFourChar);
                }
            }
            else // Otherwise print whole string
            {
                Console.WriteLine(str);
            }
        }
    }
}
