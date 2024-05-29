using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to compute the sum of the first 500 prime numbers.
 */

namespace SumOfFirst500PrimeNum
{
    internal class Program
    {
        // Function to print sum of first 500 prime numbers
        static void sumPrimeNum(int n1)
        {
            int sum = 0; // This will store the sum
            int count = 0; // This will store the count
            int num = 2; // This will store the current number to check for prime

            while(count < n1) // This will ranges from this to the end of the range
            {
                bool isPrime = true;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    sum = sum + num;
                    count++;
                }
                num++;
            }
            
            // Print the sum
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            // Get the end range of the prime numbers
            // Because range start from the 2 that's why only get the end range
            Console.Write("Enter the end range : ");
            int end = Convert.ToInt32(Console.ReadLine());

            // Call the function and print the sum of the first 500 prime numbers
            sumPrimeNum(end);
        }
    }
}
