using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to find the cumulative sum of an array of numbers.
 * A cumulative sum is a sequence of partial sums of a given sequence. 
 * For example, the cumulative sums of the sequence {x, y, z,...}, are x , x+y , x+y+z
 */

namespace CumulativeSumOfTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine();

            int[] arr = new int[size];

            Console.WriteLine("Enter the array elements below : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            int[] sumArr = new int[size];
            sumArr[0] = arr[0];

            Console.WriteLine(sumArr[0]);
            for (int i = 1; i < sumArr.Length; i++)
            {
                sumArr[i] = arr[i-1] + arr[i];
                Console.WriteLine(sumArr[i]);
            }
        }
    }
}
