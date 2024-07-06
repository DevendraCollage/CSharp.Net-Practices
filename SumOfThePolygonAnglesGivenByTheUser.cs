using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to find the sum of the
 * interior angles (in degrees) of a given polygon. Input the number of straight lines.
 */

namespace SumofThePolygonAngles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the angle of the polygon : ");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double area = (angle - 2) * 180;

            Console.WriteLine("The Sum of {0} : {1}", angle, area);
        }
    }
}
