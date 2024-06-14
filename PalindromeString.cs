using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if a given string is a palindrome or not.
 */

namespace PalindromeStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the string from the user
            Console.Write("Enter your string here : ");
            string str = Console.ReadLine();

            string rev = "";

            // Reverse the string
            for (int i = str.Length -1; i >= 0; i--)
            {
                rev = rev + str[i];
            }

            // Compare the string if paindrome or not
            if(str == rev)
            {
                Console.Write(true);
            }
            else
            {
                Console.Write(false);
            }
        }
    }
}
