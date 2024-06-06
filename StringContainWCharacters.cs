using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.
 */

namespace StringContainsWCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            // Count the specific character from the string
            int count = str.Count(x => x == 'w');

            // Check the condition w character count fall under the 1 and 3
            if (count>=1 && count <= 3) // If w count fall out of 1 and 3 then print the False otherwise True
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
