using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program to swap two numbers.
 */

namespace SwapTwonum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the First Number : ");
            int num1 = Convert.ToInt32
                (Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            int num2 = Convert.ToInt32
                (Console.ReadLine());

            // Swap the Numbers - Using Temp Variable
            int temp = num1;
            num1 = num2;
            num2 = temp;

            // Print the number after the swapping
            Console.WriteLine("After Swapping : ");
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
        }
    }
}