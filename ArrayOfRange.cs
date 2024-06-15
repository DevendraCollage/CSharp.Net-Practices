using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program that accepts a list of integers and checks how many integers are needed to complete the range.
 */

namespace ArrayofRange
{
    internal class Program
    {
        // Function to check how many integers are needed to complete the range
        public static int consecutive_array(int[] passArray)
        {
            Array.Sort(passArray);
            int ctr = 0;

            // Loop through the elements to check how many are needed
            for (int i = 0; i < passArray.Length-1; i++)
            {
                ctr = ctr + passArray[i + 1] - passArray[i] - 1;
            }

            return ctr;
        }
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize the array and set the size
            int[] arr = new int[size];

            // Read the elements of the array from the user
            Console.WriteLine("Enter the array elements below : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Call the function and pass the array and print the result
            Console.WriteLine(consecutive_array(arr));
        }
    }
}
