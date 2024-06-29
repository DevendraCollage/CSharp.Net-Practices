using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program that prints the multiplication table of a number as input.
 */

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number from the user as user wants the multiplication table
            Console.Write("Enter the number here : ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Print the multiplication table
            Console.WriteLine("The Multiplication table of : " + userNum);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(userNum + " x " + i + " = " + (userNum * i));
            }
        }
    }
}