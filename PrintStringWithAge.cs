using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
 */

namespace PrintStringWithAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get an age from the user
            Console.Write("Enter Your Age Here - ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Concate string with age
            string userStr = "You look older than " + age;

            // Print the output to the user
            Console.WriteLine(userStr);
        }
    }
}
