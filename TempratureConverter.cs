using System;

/*
 * Author - Devendra Parmar
 * Program - Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
 */

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the temperature from the user in Celsius
            Console.Write("Enter the temperature in the Celsius : ");
            float temp = Convert.ToInt64(Console.ReadLine()); // I'll converted that string number to the floating point

            // Convert the celsius tempearture to the Kelvin and Fahrenheit
            float kelvin = temp + 273.15f;
            float fahrenheit = (temp * 9 / 5) + 32;

            // Now print that converted result on the console
            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }
    }
}
