using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to remove all vowels from a given string.
 */

namespace RemoveVowelsFromTheGivenString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine()!;

            char[] array = str.ToCharArray();
            string result = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 'a' && array[i] != 'i' && array[i] != 'e' && array[i] != 'o' && array[i] != 'u')
                {
                    result = result + array[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
