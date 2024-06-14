using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to find the pair of adjacent elements that has the largest product of the given array.
 */

namespace LargestProductOfArray
{
    internal class Program
    {
        public static int array_adjacent_elem(int[] input_array)
        {
            // Initialize variables
            int index = 0;

            // Calculate the product of the first two elements
            int product = input_array[index] * input_array[index + 1];
            index++;

            // Loop to calculate the max adjacent elements of the array
            while(index+1 < input_array.Length)
            {
                product = ((input_array[index] * input_array[index + 1]) > product) ? (input_array[index] * input_array[index+1]) : product;
                index++;
            }

            return product;
        }
        static void Main(string[] args)
        {
            // Read the size of the array
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize array and set the size
            int[] arr = new int[size];

            // Read the elements of the array from the user
            Console.WriteLine("Enter array elements here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            // Call the function and pass the array
            Console.WriteLine(array_adjacent_elem(arr));
        }
    }
}
