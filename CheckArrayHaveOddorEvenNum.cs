using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check if an array contains an odd number.
 */

namespace CheckArrayHaveOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read th size of the array from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initialize the array and set the size
            int[] arr = new int[size];

            // Read the elements from the user
            Console.WriteLine("Enter the elements of the array here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Check the array contains odd numbers or not
            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }

            // Print the result
            Console.WriteLine(flag);
        }
    }
}
