using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to find the largest and lowest values from three integer values.
 */

namespace FindLargestAndLowestFromThreeNum
{
    internal class Program
    {
        // Function to check the largest number from the given three nums
        static void largestNum(double n1, double n2, double n3)
        {
            if (n1 > n2 && n2 > n3)
            {
                Console.WriteLine(n1 + " Is Greatest Among Them!");
            }
            else if (n2 > n3)
            {
                Console.WriteLine(n2 + " Is Greatest Among Them!");
            }
            else
            {
                Console.WriteLine(n3 + " Is Greatest Among Them!");
            }
        }

        // Function to check the lowest numbers from the given three nums
        static void lowestNum(double n1, double n2, double n3)
        {
            if (n1 < n2 && n2 < n3)
            {
                Console.WriteLine(n1 + " Is Lowest Among Them!");
            }
            else if (n2 < n3)
            {
                Console.WriteLine(n2 + " Is Lowest Among Them!");
            }
            else
            {
                Console.WriteLine(n3 + " Is Lowest Among Them!");
            }
        }
        static void Main(string[] args)
        {
            // Read the three numbers from the user
            Console.Write("Enter the number 1 here : ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number 2 here : ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number 3 here : ");
            double num3 = Convert.ToInt32(Console.ReadLine());

            // Call the function for the greatest number among three numbers
            largestNum(num1, num2, num3);

            // Call the function for the lowest number among three numbers
            lowestNum(num1, num2, num3);
        }
    }
}
