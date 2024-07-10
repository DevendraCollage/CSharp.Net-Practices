using System;

/*
 * Author : Devendra Parmar
 * Question : Write a C# program that finds the longest common prefix from an array of strings.
 */

namespace FindTheLongestCommonPrefixFromTheStringArray
{
    internal class Program
    {
        public static string test(string[] arrString)
        {
            if (arrString.Length == 0 || Array.IndexOf(arrString, "") != -1)
            {
                return "";
            }
            string result = arrString[0];
            int len = arrString.Length;

            foreach(string word in arrString)
            {
                int j = 0;

                foreach (char c in word)
                {
                    if (j >= len || result[j] != c)
                    {
                        break;
                    }
                    j++;
                }

                len = Math.Min(len, j);
            }

            return result.Substring(0, len);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string[] arr = new string[size];

            Console.WriteLine("Enter the array Elements here : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[{0}] : ", i);
                arr[i] = Console.ReadLine()!;
            }
            Console.WriteLine();

            Console.WriteLine("The Longest String Prefix is : {0}",test(arr));
        }
    }
}
