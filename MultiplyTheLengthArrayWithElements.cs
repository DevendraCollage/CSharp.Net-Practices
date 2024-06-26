using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to multiply all elements of a given array of numbers by array length.
 */

namespace MultiplyTheLengthArraywithElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the Array : ");
            int size = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the Array below : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            int length = arr.Length;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * length;
            }

            Console.WriteLine();
            Console.WriteLine("Array elements after multiply the element with length : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[{0}] : {1}", i, arr[i]);
            }
        }
    }
}
