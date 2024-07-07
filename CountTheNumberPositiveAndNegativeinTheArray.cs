using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to count positive and
 * negative numbers in a given array of integers.
 */

namespace CountPositiveandNegativeNumberinArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the Array : ");
            int size = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine();

            int[] arr = new int[size];

            Console.WriteLine("Enter the element here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine()!);
            }

            int posNumber = 0;
            int negativeNum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    posNumber++;
                }
                else
                {
                    negativeNum++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("The Positive Number in the Array : {0}", posNumber);
            Console.WriteLine("The Negative Number in the Array : {0}", negativeNum);
        }
    }
}
