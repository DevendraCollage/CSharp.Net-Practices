using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to calculate the sum of all integers in a rectangular matrix. However, exclude those integers located below an integer of value 0.
 * Sample Example:
 * 
    matrix = 
    [[0, 2, 3, 2],
    [0, 6, 0, 1],
    [4, 0, 3, 0]]

    Eligible integers which will be participated to calculate the sum -
    matrix = 
    [[X, 2, 3, 2],
    [X, 6, X, 1],
    [X, X, X, X]]

    Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
 */

namespace _2x2MatrixSum
{
    internal class Program
    {
        public static int sum_matrix_elements(int[,] arr)
        {
            // Variable to store the sum of the non zero elements of the given array
            int x = 0;

            // Loop through the array elements
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0) && arr[j,i] >= 0; j++)
                {
                    x = x + arr[j,i];
                }
            }

            // Return the value of the calculated sum
            return x;
        }
        static void Main(string[] args)
        {
            // Read the size of the 2x2 matrix from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize the 2x2 matrix and set the size
            int[,] arr = new int[size,size];

            // Read the elements from the user
            Console.WriteLine("Enter the array elements below : ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write("[{0}][{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Call the function and print the result
            Console.WriteLine(sum_matrix_elements(arr));


            // Print the 2D array like this given below
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(0); j++)
            //        {
            //            Console.WriteLine("[{0}][{1}] : {2}", i, j, arr[i, j]);
            //        }
            //    }
            //}
        }
    }
}
