using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to get the absolute value of the difference between two 
 * given numbers. Return double the absolute value of the difference if the first number 
 * is greater than the second number.
 */

namespace DifferenceOfTwoNumber
{
    internal class Program
    {
        // Function to return the difference between the two number
        static int differenceNum(int n1, int n2)
        {
            if(n1>n2) // This is the condition if the first number will greater than second number then double the difference
            {
                int differ = n1 - n2;
                return differ * differ;
            }
            else // Otherwise return the difference of the give number
            {
                return n1 - n2;
            }
        }
        static void Main(string[] args)
        {
            // Get the two numbers from the user
            Console.Write("Enter the number one here : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number second here : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the function and pass the value and print the result
            Console.WriteLine(differenceNum(num1, num2));
        }
    }
}
