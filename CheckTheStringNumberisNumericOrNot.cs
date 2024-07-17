using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to check if a given string 
 * (floating point and negative numbers included) is numeric or not. 
 * Return True if the string is numeric, otherwise false.
 */

namespace CheckTheStringNumberIsNumericOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter You String Here : ");
            string useStr = Console.ReadLine()!;

            double result;
            bool flag = false;
            if (double.TryParse(useStr, out result))
            {
                flag = true;
            }

            Console.WriteLine("\nThe Original Result is : {0}", result);
            Console.WriteLine("The Given String Is Numeric Or Not : {0}",flag);
            
        }
    }
}
