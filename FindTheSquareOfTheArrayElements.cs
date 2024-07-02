using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to find the sum of squares of elements in a given array of integers.
 */

namespace FIndTheSumOfTheSquareOfTheArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the Array : ");
            int size = Convert.ToInt32(Console.ReadLine()!);

            int[] arr = new int[size];
            int sum = 0;

            Console.WriteLine("\nEnter the Array Elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine()!);
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
                sum = sum + arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
