using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to reverse a Boolean value.
 */

namespace ReverseTheBooleanValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the boolean value in integer : ");
            string value = Console.ReadLine()!;

            if (value == "True" || value == "true")
            {
                Console.WriteLine("False");
            }else if (value == "False" || value == "false")
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Invalid Input");               
            }
        }
    }
}
