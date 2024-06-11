using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to rotate an array (length 3) of integers in the left direction.
 */

namespace RotateAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read an array size from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initialize the size and set the size
            int[] arr = new int[size];

            // Read the elements from the user
            Console.WriteLine("Enter the array elements here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Rotate the array
            int temp = arr[0];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i + 1]; // Shift Elements
            }
            arr[arr.Length - 1] = temp;

            // Print the rotated array  
            Console.WriteLine(arr);
        }
    }
}
