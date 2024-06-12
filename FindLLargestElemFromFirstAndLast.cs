using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.
 */

namespace FindLargestElemFromArrayFirstAndLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of Array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initialize array and set the size
            int[] arr = new int[size];

            // Read the elements from the user
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Find the first and last element of the array
            int first = arr[0];
            int last = arr[arr.Length - 1];

            // Check the which is greater from that
            if (first > last)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(last);                
            }
        }
    }
}
