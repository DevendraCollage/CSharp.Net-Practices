using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program that checks if the first element and the last element of an array of integers are equal. The array length is 1 or more.
 */

namespace CheckTheLastAndFirstElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the array here : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Declare the array and initialize the size
            int[] arr = new int[size];

            // Read the array elements from the user
            Console.WriteLine("-- Enter the array elements below --");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Access the first and last elements of the array
            int first = arr[0];
            int last = arr[arr.Length - 1];

            // Check te last elements are queal or not
            if (first ==  last)
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
