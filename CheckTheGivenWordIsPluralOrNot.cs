using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to check whether a word is plural or not.
 */

namespace CheckGivenWordIsPluralOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word here : ");
            string word = Console.ReadLine()!;

            if (word.EndsWith('s'))
            {
                Console.WriteLine("This is a Plural Word!");
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine("This is not Plural Word!");
                Console.WriteLine(false);
            }
        }
    }
}
