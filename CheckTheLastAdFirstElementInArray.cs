using System;

/*
 * Author - Devendra Parmar
 * Program - Check if a number appears as either the first or last element of an array of integers.
 */

namespace CheckTheLastAndFirstElementArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the array size from the user
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());

            // Declare an array and set the size
            int[] arr = new int[size];
            int len = arr.Length;

            // Read the elements of the array from the user
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Read the number user want to search available at last or first of the array
            Console.Write("Enter the number search is available of the last or first : ");
            int countNum = Convert.ToInt32(Console.ReadLine());

            // Check the nnumber is avilable or not
            bool isInclude = false;
            if (arr[0] == countNum || (arr[len - 1]) == countNum)
            {
                isInclude = true;
            }

            // Print the result
            Console.WriteLine(isInclude);
        }
    }
}
