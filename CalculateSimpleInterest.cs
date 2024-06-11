using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program to calculate Simple Interest.
 */

namespace CalculateSimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the Principal amount, Rate of interest, number of years from the user
            Console.Write("Principal Amount : ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rate of Interest : ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Years : ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Calculate the Simple Interest
            double SI = (p * r * n) / 100;
            Console.WriteLine();

            // Print the simple interest
            Console.WriteLine(SI);
        }
    }
}
