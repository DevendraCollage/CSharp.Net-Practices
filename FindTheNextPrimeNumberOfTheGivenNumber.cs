using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to find the next prime number of a given
 * number. If the given number is a prime number, return the number.
 */

namespace FindTheNextPrimeNumberOfTheGivenPrimeNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the prime number here : ");
            int prime = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < prime; i++)
            {
                if (prime%i==0)
                {
                    prime++;
                    i = 2;
                }
            }

            Console.WriteLine(prime);
        }
    }
}
