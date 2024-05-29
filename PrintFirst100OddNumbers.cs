using System;

/*
 * Author - Devendra Parmar
 * Program -  Write a C# program to print odd numbers from 1 to 99. Prints one number per line.
 */

namespace PrintFirst100OddNum
{
    internal class Program
    {
        // Function to print from start to end between range given by the user
        static void oddNum(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            // Get the start and end range from the user
            Console.Write("Enter the start range : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end range : ");
            int end = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the Odd number on particular line
            oddNum(start, end);
        }
    }
}
