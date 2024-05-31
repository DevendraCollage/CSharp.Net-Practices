using System;
using System.Collections.Generic; // Import this class to use this class inbuilt methods to convert the hex number to decimal number

/*
 * Author - Devendra Parmar
 * Program - Convert a hexadecimal number to decimal number
 */

namespace HexNumToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the hex number from the user
            Console.Write("Enter the Hexadecimal number : ");
            string hexNum = Console.ReadLine();

            // Print the hex number
            Console.WriteLine("This is an Hexadecimal number : " + hexNum);

            // Convert the hex number into decimal number
            int dec = int.Parse(hexNum, System.Globalization.NumberStyles.HexNumber); // This is the inbuilt method to convert to hex number to decimal

            // Print the converted decimal number
            Console.WriteLine("The converted hex number into decimal number : " + dec);
        }
    }
}
