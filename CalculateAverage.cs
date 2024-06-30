using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program that takes four numbers as input to calculate and print the average.
 */

namespace CalculateAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the four numbers from the users
            Console.Write("Enter the number one here : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number two here : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number three here : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number four here : ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            // Calculate the average of the user entered number
            double avg = (num1 + num2 + num3 + num4)/4;

            // Print the average of the user entered numbers
            Console.WriteLine("The Avergae of - " + num1 + "," + num2 + "," + num3 + "," + num4 + " is : " + avg);
        }
    }
}