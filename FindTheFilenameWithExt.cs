using System;
using System.Linq;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to get the file name (including extension) from a given path.
 */

namespace FindFilenameWithExt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find the file name extension
            string filePath = "C:/Users/Devendra/Desktop/C#.Net/Practice Programs/FindFilenameWithExt/Program.cs";

            Console.WriteLine(filePath.Split('/').Last());
        }
    }
}
