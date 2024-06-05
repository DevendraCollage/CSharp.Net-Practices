using System;

/*
 * Author - Devendra Parmar
 * Program - Check the nearest value of 20 of two given integers and return 0 if two numbers are same
 */

namespace NearestNumOf20
{
    internal class Program
    {
        // Function to check the nearest number of 20 otherwise return 0
        static void checkNum(double n1, double n2)
        {
            if(n1 == n2)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (n1>=15)
                {
                    Console.WriteLine(n1 + " Is Nearest Number of 20!");
                }
                else if(n2>=15)
                {
                    Console.WriteLine(n2 + " Is Nearest Number of 20!");
                }
            }
        }
        static void Main(string[] args)
        {
            // Read the two integers from the user
            Console.Write("Enter the 1 number here : ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2 number here : ");
            double num2 = Convert.ToInt32(Console.ReadLine());

            // Call the function and pass the numbers
            checkNum(num1, num2);
        }
    }
}
