using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# program to check if a given number is present in an array of numbers.
 */

namespace FindGivenNumberPresentInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read size of the array
            Console.Write("Enter the size of the array : ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Array and their size
            int[] arr = new int[size];

            // Read the elements
            Console.WriteLine("Enter the elements below : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine()!);
            }
            Console.WriteLine();

            // Get number from user
            Console.Write("Enter the element that will find : ");
            int arrNum = int.Parse(Console.ReadLine()!);

            // Find element
            bool temp = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arrNum == arr[i])
                {
                    temp = true;
                    break;
                }
            }

            Console.WriteLine(temp);
        }
    }
}
