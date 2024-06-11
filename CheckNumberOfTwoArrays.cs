using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.
 * Test Data:
 * Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]
 * Array2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]
 * Check if the first element or the last element of the two arrays ( leng th 1 or more) are equal.
 */

namespace CheckNumOfTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the two array size from the user
            Console.Write("Enter the size of the array-1 : ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of the array-2 : ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize the array and set the size
            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            // Read the first array elements from the user
            Console.WriteLine("Enter the elements of the array-1 : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            // Read the second array elements from the user
            Console.WriteLine("Enter the elements of the array-2 : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Get the first elements of the two arrays
            int firstArr1 = arr1[0];
            int firstArr2 = arr2[0];

            // Get the last elements of the two arrays
            int secondArr1 = arr1[arr1.Length - 1];
            int secondArr2 = arr2[arr2.Length - 1];
;
            // Now match the first and last elements with each other
            if(firstArr1 == firstArr2 || secondArr1 == secondArr2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
