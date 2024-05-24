using System;

/*
 * Author - Devendra Parmar
 * Program - Remove specified a character from a non-empty string using index of a character
 */

namespace RemoveSpecifiedCharacters
{
    internal class Program
    {
        // This is the main method where the program execution starts
        static void Main(string[] args)
        {
            // Displaying a result after removing the character at the specified index
            // Index starts from the 0
            Console.WriteLine(RemoveChar("DevendraParmar", 0));
            Console.WriteLine(RemoveChar("Darshan University", 5));
            Console.WriteLine(RemoveChar("India is the great the country!", 8));
        }

        // Function to remove character at the specified index
        public static string RemoveChar(string str, int n)
        {
            return str.Remove(n, 1);
            // Exaplnation of the Function Remove():
            /*
             * - in the remove function n means where the deletion starts.
             * - 1 means how many characters to remove from the string.
             */
        }
    }
}
