using System;

/*
 * Author - Devendra Parmar
 * Program - Get the century from a year.
 */

namespace CheckTheCenturyYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the year from the user
            Console.Write("Enter the year here : ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check the given year is century year or not
            if(year%100==0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
