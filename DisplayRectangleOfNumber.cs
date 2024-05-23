using System;

/*
 * Author - Devendra Parmar
 * Program - Display a number in rectangle of 3 columns wide and 5 rows tall using that digit
 */

namespace DisplayRectangleOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number from the user
            Console.Write("Enter the digit here : ");
            int digit = Convert.ToInt32(Console.ReadLine());

            // Print the rectangle of this user entered number
            Console.WriteLine("{0} {0} {0}", digit);
            Console.WriteLine("{0}   {0}", digit);
            Console.WriteLine("{0}   {0}", digit);
            Console.WriteLine("{0}   {0}", digit);
            Console.WriteLine("{0} {0} {0}", digit);
        }
    }
}
