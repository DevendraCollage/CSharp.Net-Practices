using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# Sharp program to check whether all characters in a
 * string are the same. Return true if all the characters in the string are
 * the same, otherwise false.
 */

namespace CheckTheAllChacractersInTheStringAreSame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string here : ");
            string str = Console.ReadLine()!;
            Console.WriteLine();

            char[] chars = str.ToCharArray();

            bool flag = true;

            var c = chars[0];

            for (int i = 1; i < chars.Length; i++)
            {
                var d = chars[i];

                if (c != d)
                {
                    flag = false;
                }
            }

            Console.WriteLine(flag);
        }
    }
}
