using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to count a specified character (both cases) in a given string.
 */

namespace CountCharacterintheString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the String here : ");
            string str = Console.ReadLine()!;
            Console.WriteLine();

            Console.Write("Enter the string character to find how many time occur : ");
            char wordChar = Console.ReadKey().KeyChar!;
            Console.WriteLine();

            int count = 0;

            foreach (char item in str)
            {
                if(char.ToLower(item) == wordChar)
                {
                    count++;
                }
            }

            Console.WriteLine("\nThe given word {0} character count is : {1}", wordChar, count);
        }
    }
}
