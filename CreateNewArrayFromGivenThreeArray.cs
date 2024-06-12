using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers.
 */


namespace CreateNewArrFromGiveThreeArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the size of the array from the user
            Console.Write("Enter the size of the Array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Initialize all the three arrays
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] arr3 = new int[size];

            // Read the elements of all the three arrays
            Console.WriteLine("Enter the elements of the Array-1 : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            // Read the elements of the second array
            Console.WriteLine("Enter the elements of the Array-2 : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            // Read the elements of the second array
            Console.WriteLine("Enter the elements of the Array-3 : ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr3[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Get the all the arrays centered elements
            int first = arr1[arr1.Length/2];
            int second = arr2[arr2.Length / 2];
            int third = arr3[arr3.Length / 2];

            // Now create the new array from that elements
            int[] newArr = new int[size];
            newArr[0] = first;
            newArr[1] = second;
            newArr[2] = third;

            // Print the new array
            Console.WriteLine();
            Console.WriteLine("Generate Array from the centered element of the all the three arrays : ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }
    }
}
