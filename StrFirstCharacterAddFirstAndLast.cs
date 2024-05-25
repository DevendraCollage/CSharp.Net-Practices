using System;

/*
 * Author - Devendra Parmar
 * Program - Create a new string from a given string with the first character added at the front and back
 */

namespace StrFirstCharacterAddFirstAndLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            // Extract the first character of the string and store it in the string variable
            string firstChar = str.Substring(0, 1); // In This 0 means start index and 1 means of length 

            // Now Append the string with this character first and last
            string appendString = firstChar + " " + str + " " + firstChar; // In This line we are add the first character of the string to the first and last of the userstring
            Console.WriteLine(appendString);
        }
    }
}
