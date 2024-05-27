using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to check the sum of the two given integers. Return true if 
 * one of the integers is 20 or if their sum is 20.
 */

namespace CheckTheSumis20
{
    internal class Program
    {
        /* Function to check the give two integers of the sum is 20 or given the number is
         * one of the integer is true then retun true otherwise false.
        */
        static bool checkSum(int n1, int n2)
        {
            if((n1+n2) == 20 || n1 == 20 || n2 == 20)
            {
                Console.WriteLine("The given integer sum is 20 or one of the integer is 20 : ");
                return true;
            }
            else
            {
                Console.WriteLine("The given integer sum is not 20 or one of the any number is not 20 : ");
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Get the two integers from the user
            Console.Write("Enter the number one here : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number two here : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the value
            Console.WriteLine(checkSum(num1, num2));
        }
    }
}
