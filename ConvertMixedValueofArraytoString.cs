using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to convert all the values of a given array of mixed values to string values.
 */

namespace ConvertMixedValueOfArraytoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the Array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            object[] arr = new object[size];

            Console.WriteLine("Enter the array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Console.ReadLine()!;
            }
            Console.WriteLine();

            Console.WriteLine("Print the value and their type");
            string[] strArr = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                strArr[i] = arr[i].ToString()!;
                Console.WriteLine("[{0}] : {1} + and type is {2}", i, strArr[i], strArr[i].GetType());
            }
        }
    }
}
