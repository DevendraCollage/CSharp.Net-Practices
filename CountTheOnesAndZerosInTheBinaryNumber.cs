using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to count the number of
 * ones and zeros in the binary representation of a given integer.
 */

namespace CountTheOnesAndZerosInTheBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine()!);

            string binaryNum = Convert.ToString(num, 2);
            char[] arr = binaryNum.ToCharArray();

            int zerosCount = 0;
            int onesCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {    
                if (arr[i] == '0')
                {
                    zerosCount++;
                }
                else
                {
                    onesCount++;
                }
            }
            Console.WriteLine();

            Console.WriteLine("The Zeros Count in the Binary Number is : {0}", zerosCount);
            Console.WriteLine("The Ones Count in the Binary Number is : {0}", onesCount);
        }
    }
}
