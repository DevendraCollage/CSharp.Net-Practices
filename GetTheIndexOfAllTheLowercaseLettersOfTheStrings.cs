using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to get the index number of all lower case letters in a given string.
 */

namespace GetTheIndexOfAllTheLowercaseLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine()!;
            Console.WriteLine();

            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLower(chars[i]))
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
