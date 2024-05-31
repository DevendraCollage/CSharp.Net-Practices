using System;
using System.IO; // Importing the System.IO namespace for file handling.

/*
 * Author - Devendra Parmar
 * Program - Find the size of a specified file in bytes
 */

namespace FindSizeOfFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You have to handle the Exception using try and catch
            try
            {
                // Create the instance of the FileInfo to use the function to get the file info
                FileInfo fi = new FileInfo("C:\\Users\\Devendra\\Desktop\\Demo.txt"); 

                // Print the size of the give file in the byte
                Console.WriteLine("The size of the given file is : " + fi.Length.ToString());
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("The given file is not found on the computer : " + e.ToString());
            }
        }
    }
}
