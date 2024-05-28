using System;
using System.Runtime.CompilerServices;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to find the longest word in a string.
 */

namespace LongestWordInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the string from the user
            Console.Write("Enter the string you want : ");
            string userStr = Console.ReadLine();

            // Splitting the string into words based on spaces and storing them in an array
            string[] words = userStr.Split(new[] { " " }, StringSplitOptions.None);

            string word = ""; // Initializing an empty string to store the word with the maximum length
            int ctr = 0; // Initializing a counter variable to keep track of the maximum length

            // Looping through each word in the words array
            foreach (String s in words)
            {
                // Checking if the length of the current word is greater than the stored maximum length
                if (s.Length > ctr)
                {
                    word = s; // If the current word's length is greater, update the 'word' variable
                    ctr = s.Length; // Update the maximum length counter
                }
            }

            // Print the longest word of the string
            Console.WriteLine(word);
        }
    }
}
