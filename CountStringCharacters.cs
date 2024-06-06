using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.
 */

namespace CountStringCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine();

            // Count the characters of the string
            int count = str.Count();

            // Make the Condition count > 4 then make first 4 characters in lowercase
            if(count <= 4)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {
                string firstFour = str.Substring(0, 4);
                string f = firstFour.ToLower();
                string afterFour = str.Substring(4);
                string a = afterFour.ToUpper();
                Console.WriteLine(f + a);
            }
        }
    }
}
