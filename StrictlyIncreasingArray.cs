using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check whether it is possible to create a strictly increasing sequence
 * from a given sequence of integers as an array.
 */

namespace StrictlyIncreasingArray
{
    internal class Program
    {
        // Function to check it is possible or not to create a strictly increasing sequence of array.
        public static bool test_increasing_sequence(int[] arr)
        {
            // Initialize variables
            int x = 0;

            // Loop through the array and check the elements
            for (int i = 0; i < arr.Length-1; i++)
            {
                // First condition to check 
                if (arr[i] >= arr[i+1])
                {
                    x++;
                }

                // Second condition if first condition will be false
                if(i+2 < arr.Length && arr[i] >= arr[i+2])
                {
                    x++;    
                }
            }

            return x <= 2;
        }
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size here : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize the array and set the size
            int[] arr = new int[size];

            // Read the elements of the array from the user
            Console.WriteLine("Enter the array elements here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Call the function and print the result
            Console.WriteLine(test_increasing_sequence(arr));
        }
    }
}
