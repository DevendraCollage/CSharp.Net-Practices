using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to check whether the average value of the elements
 * of a given array of numbers is a whole number or not.
 */

namespace CalculateTheAverageOfTheArrayAndCheckTheNumberIsWhole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the Array : ");
            int size = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            int[] arr = new int[size];

            Console.WriteLine("Enter the array element below : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine();

            double average = arr.Average();
            Console.WriteLine("Your Array Average is : {0}", average);
            Console.WriteLine();

            if(average % 1 == 0)
            {
                Console.Write("Which is Whole Number : ");
                Console.WriteLine(true);
            }
            else
            {
                Console.Write("Which is Not Whole Number : ");
                Console.WriteLine(false);
            }
        }
    }
}
