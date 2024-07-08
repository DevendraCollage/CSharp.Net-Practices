using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to remove all values except integer values from a given array of mixed values.
 */

namespace RemoveOtherValuesfromArrayWithoutTouchInteger
{
    internal class Program
    {

        public static int[] test(object[] nums)
        {
            return nums.OfType<int>().ToArray();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            object[] arr = new object[size];

            Console.WriteLine("Enter array elements here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                string input = Console.ReadLine()!;

                if (int.TryParse(input, out int intValue))
                {
                    arr[i] = intValue;
                }
                else
                {
                    arr[i] = input;
                }
            }

            int[] numArr = test(arr);

            Console.WriteLine("\nAfter removing all the values except integer values from the said array of mixed values:");
            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine(numArr[i] + " ");
            }
        }
    }
}
