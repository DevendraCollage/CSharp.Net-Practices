using System;

/*
 * Author - Devendra Parmar
 * Program - Create a new string from a given string where the first and last characters will change their positions
 */

namespace ChangeStringPosition
{
    internal class Program
    {
        // This is the main method where the program execution starts
        static void Main(string[] args)
        {
            // Displaying the result after the rearanging the string
            Console.WriteLine(First_Last("Devendra Parmar")); // This will change the first and last characters of the string
        }

        // Function to rearrange the string first and last characters
        public static string First_Last(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
            // Explanation of the give program:
            /*
             * - First if the length of the string is greater than 1 then print the substring
             * - If length of the string is not greater than 1 means string only have one character then print the whole string
             */
        }
    }
}
