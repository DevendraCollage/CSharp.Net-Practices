using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to reverse the words of a sentence.
 */

namespace ReverseTheSentence
{
    internal class Program
    {

        // Function to reverse the string given by the user
        public static string reversedString(string s)
        {
            string sentence = ""; // Empty string to store the reversed string sentence
            List<string> list = new List<string>(); // Create the list to store the reversed string
            string[] words = s.Split(' '); // This will split the string into individual words  
            if (s == null)
            {
                return String.Empty;
            }
            else
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    sentence = sentence + words[i] + " "; // Store the reversed string into the sentence
                }
            }
            return sentence;
        }
        static void Main(string[] args)
        {
            // Get the sentence from the user
            Console.Write("Enter the sentence here : ");
            string sen = Console.ReadLine();

            // Call the function the print the reversed string
            Console.WriteLine("String before reversed : " + sen);
            Console.Write("String after reversed : " + reversedString(sen));
        }
    }
}
