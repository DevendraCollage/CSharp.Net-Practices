using System;
using System.Text;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to get the ASCII value of a given character.
 */

namespace AscciCodeOfTheGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number here : ");
            char chr = Console.ReadKey().KeyChar!;
            Console.WriteLine();

            Console.WriteLine("The Ascci Code {0} is {1}", chr, (int)chr);
        }
    }
}
