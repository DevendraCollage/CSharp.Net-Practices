using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
 * Expected Output - Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
 */

namespace UserSpecifiedArithmaticOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the three numbers from the user
            Console.Write("Enter the number one here : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number two here : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number here : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Perform the specified output
            double result1 = (num1 + num2) * num3;
            double result2 = (num1 * num2) + (num2 * num3);

            // Print the specified result given in that Expected Output :
            Console.WriteLine("Result of specified numbers " + num1 + "," + num2 + " and " + num3 + " is " + "(x+y)*z = " + result1 + " and " + "x*y + y*z = " + result2);
        }
    }
}