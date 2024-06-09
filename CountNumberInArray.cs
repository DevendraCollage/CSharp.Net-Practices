using System;

/*
 * Author - Devendra Parmar
 * Program - Count a specified number in a given array of integers
 */

namespace CountNumInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the array here : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Implement the array given by the user
            int[] arr = new int[size];

            // Read the elements of the array from the user
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            // Read the number user want to count
            Console.Write("Enter the digit you want to count : ");
            int numCount = Convert.ToInt32(Console.ReadLine());

            // Count the specific user choice number
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (numCount == arr[i])
                {
                    count = count + 1;
                }
            }
            Console.WriteLine();

            // Print the user specific number count
            Console.Write("The count of {0} is in the array : {1}", numCount, count);
        }
    }
}
