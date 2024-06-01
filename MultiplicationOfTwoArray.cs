using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to multiply the corresponding elements of two integer arrays.
 * Note: Use the getlength() method to get and use the length of the array
 */

namespace MultipleOfTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the size of the array
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initialize the two dimensional array
            int[,] arr = new int[size,size];

            // Get the element of the array from the user
            Console.WriteLine("\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i}][{j}] : ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Initialize the sum array where to store the calculation
            int[,] sum = new int[size,size];

            // Multiply the array elements
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum[i,j] = arr[i,j] * arr[i,j];
                }
            }

            // Print the calculation of the two array
            Console.WriteLine("\nPrint the calculation of the two array : ");
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.WriteLine(sum[i, j] + " ");
                }
            }
        }
    }
}
