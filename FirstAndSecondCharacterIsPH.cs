using System;

/*
 * Author - Devendra Parmar
 * Program -  Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be "P" and "H", so PHP will be "PH".
 */

namespace FirstAndSecondCharacterPH
{
    internal class Program
    {
        // Function to check the string is contain P(First) and H(Second) and remove all the characters
        static string checkStr(string str)
        {
            if (str.Length >= 2 && str.Substring(0, 2) == "PH")
            {
                return str.Substring(0, 2);
            }
            else
            {
                return str;
            }
        }
        static void Main(string[] args)
        {
            // Get the string from the user
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine();

            // Call the function and print the result
            Console.WriteLine(checkStr(str));
        }
    }
}
