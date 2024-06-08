using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if a given string starts with "w" and is immediately followed by two "ww".
 */

namespace CheckStringStartsWithWOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            string strChar = "w"; // This is the character where have to check
            
            // Condition to check the user string starts with w or not and immediately character is ww
            if(str.StartsWith(strChar) && str.Substring(1, 2).StartsWith(strChar)){
                Console.WriteLine(true);
            }else
            {
                Console.WriteLine(false);
            }
        }
    }
}
