using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to compute the sum of all the elements of an array of integers.
*/

namespace SumOfArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size here : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize the array and set the size
            int[] arr = new int[size];
            int sum = 0; // Initial value for the sum of the array elements

            // Read the array elements from the user
            Console.WriteLine("-- Enter the array elements below -- ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            // Now calculate the sum of the given array
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            // Print the sum of the arrat elements
            Console.WriteLine("The sum of the given array elements is : {0}", sum);
        }
    }
}
