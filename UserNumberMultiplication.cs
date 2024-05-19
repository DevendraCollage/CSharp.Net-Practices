using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
 */

namespace UserNumberMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number from the user
            Console.Write("Input First Number to Multiply : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second Number to Multiply : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Third Number to Multiply : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Print the result to the user
            // I use the Interpolation to print the result of the user
            Console.WriteLine($"{num1} x {num2} x {num3} = {num1 * num2 * num3}");
        }
    }
}
