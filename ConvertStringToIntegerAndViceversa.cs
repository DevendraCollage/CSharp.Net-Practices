using System;
using System.IO;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to convert an integer to a string and a string to an integer.
 */

namespace ConvertStringtoIntegerAndViceVersa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number here : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string strNum = Convert.ToString(num);

            Console.WriteLine("The Number Convert Into String : {0} and Their Type : {1}", strNum, strNum.GetType());
            Console.WriteLine("The String Number Convert Into Number : {0} and Their Type : {1}", Convert.ToInt32(strNum), Convert.ToInt32(strNum).GetType());

            Console.WriteLine("\nThe String Number Convert Into Number : {0} and Their Type : {1}", num, num.GetType());
            Console.WriteLine("The Number Convert Into String : {0} and Their Type : {1}", strNum, strNum.GetType());
        }
    }
}
