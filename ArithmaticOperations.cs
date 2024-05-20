using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
 */

namespace ArithmaticOperations
{
   internal class Program
    {
        static void Main(string[] args)
        {
            // Get the two number from the user
            Console.Write("Input the first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine
                ());
            Console.Write("Input the second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Perform the required arithmatic operations and print the result
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine(num1 + " mod " + num2 + " = " + (num1 % num2));
            
            
        }
    }
}
